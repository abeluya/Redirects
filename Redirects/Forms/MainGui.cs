/*
 * Created by Abraham Oviedo
 * April, 2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Web;
using System.Net.NetworkInformation;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace Redirects
{
    public partial class frmMain : Form
    {

        //Variables begin

        private Configurations config = new Configurations();
        private string[] split;
        private List<Redirect> list = new List<Redirect>(); //Stores the list of URLs
        private bool permanentRedirect = true;
        private int response = 301;
        private bool passed = true;
        private string domainName = ""; //Domain name to add to hostsfiles
        private IWebDriver driver;
        private bool redirectsLoaded = false; //True only when the redirects are properly loaded
        private LoadingForm loading;

        //Variables end

        //Constructors begin
        public frmMain()
        {
            InitializeComponent();
            this.txtIp.Text = this.GetIP(this.config.StagingIp); //Get IP of staging server
            
        }
        //Contructors end

        //Methods begin
        private void LoadCSV() //Not working at the moment
        {
            var reader = new StreamReader(File.OpenRead(this.config.FilePath));
            List<string> searchList = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            reader.Close();
            foreach (string line in searchList)
            {
                split = line.Split(',');
                Console.WriteLine(split[split.Length - 1]);
                this.dataGridLista.Rows.Add(split[1], split[10], split[11]);
            }
        }

        private bool ClipBoardLoad() //loads into the list the content of the clipboard
        {

            try
            {
                this.list.Clear();
                this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
                {
                    split = Regex.Split(Clipboard.GetText(TextDataFormat.Text), "\r\n");
                });

                foreach (string i in split)
                {
                    if (i.Length > 1)
                    {
                        string[] test;
                        test = i.Split('\t');
                        Console.WriteLine("Origin: {0}\nDestino: {1}", test[0], test[test.Length - 1]);

                        if (test[0].Contains("https://"))
                        {
                            this.list.Add(new Redirect(test[0], test[1]));
                        }
                        else
                        {
                            if (test[0].Contains("http://"))
                            {
                                this.list.Add(new Redirect(test[0], test[1]));
                            }
                            else
                            {
                                this.list.Add(new Redirect("https://" + test[0], "https://" + test[1]));
                            }
                        }
                    }


                }
                return true;
            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
                this.DialogMessage("Non-supported format on clipboard. Please make sure to copy only valid URLs.", "ERROR MESSAGE", 1);
                return false;
            }

        }

        private void GetResponse() //Gets the response code for every item o the list
        {
            this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
            {
                this.loading.lblStatus.Text = "Getting response codes";
            });
            HttpWebRequest myHttpWebRequest;
            HttpWebResponse myHttpWebResponse;
            for (int i = 0; i < this.list.Count; i++)
            {
                try
                {
                    myHttpWebRequest = (HttpWebRequest)WebRequest.Create(this.list[i].Origin);
                    myHttpWebRequest.Timeout = 1000;
                    myHttpWebRequest.ReadWriteTimeout = 1000;
                    myHttpWebRequest.AllowAutoRedirect = false;
                    if (this.chkV2.Checked)
                    {
                        myHttpWebRequest.Headers["v2header"] = "true";
                    }
                    myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                    Console.WriteLine(myHttpWebResponse.StatusCode);
                    if (myHttpWebResponse.StatusCode == HttpStatusCode.MovedPermanently)
                    {
                        this.list[i].Response = 301;
                    }
                    else if (myHttpWebResponse.StatusCode == HttpStatusCode.Redirect)
                    {
                        this.list[i].Response = 302;
                    }
                    else if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    {
                        this.list[i].Response = 200;
                    }
                    else if (myHttpWebResponse.StatusCode == HttpStatusCode.NotFound)
                    {
                        this.list[i].Response = 404;
                    }
                    else this.list[i].Response = 404;
                    Console.WriteLine(this.list[i].Response);
                    myHttpWebResponse.Close();
                }
                catch
                {
                    this.list[i].Response = 404;
                }
                this.UpdatePgrBar();

            }
        }


        private void CompareURL() //Compares the destiny URL with the actual URL of the httpResponse
        {
            this.GetResponse();
            HttpWebRequest myHttpWebRequest;
            HttpWebResponse myHttpWebResponse;
            for (int i = 0; i < this.list.Count; i++)
            {

                try
                {
                    Console.WriteLine(this.list[i].Response);
                    if ((this.list[i].Response == 301) || (this.list[i].Response == 302))
                    {
                        myHttpWebRequest = (HttpWebRequest)WebRequest.Create(this.list[i].Origin);  //Sends origin URL
                        myHttpWebRequest.Timeout = 1000;
                        myHttpWebRequest.ReadWriteTimeout = 1000;
                        myHttpWebRequest.AllowAutoRedirect = true;
                        if (this.chkV2.Checked)
                        {
                            myHttpWebRequest.Headers["v2header"] = "true";
                        }
                        myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();    // Gets a response URL based on the origin URL
                        Console.WriteLine(myHttpWebResponse.StatusCode);

                        this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
                        {
                            this.list[i].ServerDestiny = myHttpWebResponse.ResponseUri.ToString();
                            if (this.list[i].Destiny.Equals(this.list[i].ServerDestiny, StringComparison.InvariantCultureIgnoreCase)) //Compare destiny vs httpResponse URLs
                            {
                                if (this.list[i].Response == this.response) // Compare response code
                                {
                                    this.list[i].Passed = 1;
                                    this.list[i].Result += "All Ok";
                                }
                                else
                                {
                                    //ModifyProgressBarColor.SetState(this.pgrBar, 2); //Changes progress bar to red
                                    this.list[i].Result += "Wrong response code";
                                    this.passed = false;
                                }

                            }
                            else
                            {
                                this.list[i].Result = "Destiny URL does not match (" + myHttpWebResponse.ResponseUri.ToString() + ")";
                                //ModifyProgressBarColor.SetState(this.pgrBar, 2); //Changes progress bar to red
                                this.passed = false;

                            }
                        });
                        Console.WriteLine("Destiny: {0}", this.list[i].Destiny);
                        Console.WriteLine("Server destiny {0}\nPassed? {1}", this.list[i].ServerDestiny, this.list[i].Passed);
                        myHttpWebResponse.Close();

                    }

                    else
                    {
                        //ModifyProgressBarColor.SetState(this.pgrBar, 2); //Changes progress bar to red
                        switch (this.list[i].Response)
                        {
                            case 200:
                                this.list[i].Result = "Redirect does not exist.";
                                break;
                            case 404:
                                this.list[i].Result = "Could not reach destiny URL.";
                                break;

                            default:
                                this.list[i].Result = "URL was not tested.";
                                break;
                        }
                        this.passed = false;

                    }

                    this.UpdatePgrBar();

                }
                catch (System.ArgumentOutOfRangeException error)
                {
                    Console.WriteLine(error);
                    Console.WriteLine("Please load the URLs first");
                    this.DialogMessage("Please load the URLs first", "ERROR MESSAGE", 1);
                }
                catch (System.Net.WebException webEx) //Response code is ok but destiny is unreachable
                {
                    Console.WriteLine(webEx);
                    Console.WriteLine("Las URL cargaron indebidamente");
                    if (this.list[i].Response == this.response) // Compare response code
                    {
                        this.list[i].Result += "Could not reach destiny URL";
                        this.list[i].Passed = 2;
                        this.passed = false;
                    }
                    else
                    {
                        //ModifyProgressBarColor.SetState(this.pgrBar, 2); //Changes progress bar to red
                        this.list[i].Result += "Wrong response code. Also could not reach destiny URL";
                        this.list[i].Passed = 0;
                        this.passed = false;
                    }

                    this.UpdatePgrBar();
                    //this.DialogMessage("Error: " + webEx.ToString(), "ERROR MESSAGE", 1);

                }

            }
            this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
            {
                this.FillGrid();
                this.HidePanel();
                this.Enabled = true;

                //Brings form to the front
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;

                this.Show();
                this.Activate();
                this.ShowInTaskbar = true;
                this.TopMost = true;
                this.Focus();
                this.TopMost = false;
                //Brings form to the front
            });



        }
        public void UpdatePgrBar()
        {
            this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
            {
                this.loading.pgrBar.PerformStep();
            });

        }
        private bool WriteHosts()
        {
            try
            {
                Console.WriteLine(this.config.HostsPath);
                using (StreamWriter stream = new StreamWriter(this.config.HostsPath, true, Encoding.Default))
                {
                    //stream.WriteLine(System.Environment.NewLine + this.txtIp.Text + " " + this.txtUrl.Text);
                    stream.Write(System.Environment.NewLine + this.txtIp.Text + " " + this.txtUrl.Text);
                    stream.Close();
                }
                return true;
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine(e);
                this.DialogMessage("Unable to write the hosts file", "ERROR MESSAGE", 0);
                return false;
            }
        }

        private bool WriteHostsTest()
        {
            try
            {
                if (File.Exists(this.config.HostsPath))
                {
                    List<string> lines = File.ReadAllLines(this.config.HostsPath).ToList();
                    //File.WriteAllLines(this.config.HostsPath, lines.GetRange(0, lines.Count - 1).ToArray());
                    Stream stream = File.OpenWrite(this.config.HostsPath);
                    StreamWriter writer = new StreamWriter(stream);
                    if (lines.Count > 0)
                    {
                        stream.SetLength(0);
                        for (int i = 0; i < lines.Count - 1; i++)
                        {
                            writer.WriteLine(lines[i]);
                        }
                        //writer.Write(lines[lines.Count - 1]);
                    }
                    writer.WriteLine(this.txtIp.Text + " " + this.txtUrl.Text);
                    stream.Close();
                    return true;
                }
                return false;
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine(e);
                this.DialogMessage("Unable to write the hosts file", "ERROR MESSAGE", 0);
                return false;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                this.DialogMessage(e.ToString(), "ERROR MESSAGE", 0);
                return false;
            }
        }

        private string GetIP(string Url)
        {
            try
            {
                Uri myUri = new Uri(Url); //Obtains IP
                string ip = Dns.GetHostAddresses(myUri.Host)[0].ToString();
                return ip;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                return "ERROR";
            }
        }

        private void DeleteLastLine()
        {

            try
            {

                Console.WriteLine(this.config.HostsPath);
                //List<string> lines = File.ReadAllLines(this.config.HostsPath).ToList();
                //File.WriteAllLines(this.config.HostsPath, lines.GetRange(0, lines.Count - 1).ToArray());
                /*Stream stream = File.OpenWrite(this.config.HostsPath);
                StreamWriter writer = new StreamWriter(stream);
                if (lines.Count > 0)
                {
                    stream.SetLength(0);
                    for (int i = 0; i < lines.Count - 1; i++)
                    {
                        writer.WriteLine(lines[i]);
                    }
                   //writer.Write(lines[lines.Count - 1]);
                }
                stream.Close();*/
                using (var writer = new StreamWriter(this.config.HostsPath))
                {
                    using (var reader = new StreamReader(this.config.HostsPath))
                    {
                        //Ignore first line
                        reader.ReadLine();
                        string line;
                        do
                        {
                            line = reader.ReadLine();

                            //Until we read the last line, write out the
                            //current line - note that blank lines count
                            if (!reader.EndOfStream)
                                writer.WriteLine(line);
                        } while (line != null);
                        reader.Close();
                    };
                };

            }
            catch (System.IO.FileNotFoundException)
            {
                this.DialogMessage("hosts file not found!", "CRITICAL", 0);
            }

        }

        private string GetDomain(string Url)
        {
            try
            {

                Uri myUri = new Uri(Url); //Obtains URL
                Console.WriteLine(myUri.Host);
                return myUri.Host.ToString();

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                return "ERROR";
            }
        }


        private void FillGrid()
        {
            this.dataGridLista.Rows.Clear();
            foreach (Redirect r in this.list)
            {
                if (r.Response != 0)
                {
                    this.dataGridLista.Rows.Add(r.Origin, r.Destiny, "Response code " + r.Response.ToString() + ": " + r.Result + ".");
                }
                else
                {
                    this.dataGridLista.Rows.Add(r.Origin, r.Destiny, "");
                }

                switch (r.Passed)
                {
                    case 0: //Red text in Status field
                        this.dataGridLista.Rows[dataGridLista.RowCount - 1].Cells["status"].Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                        break;
                    case 1:  //Green text in Status field
                        this.dataGridLista.Rows[dataGridLista.RowCount - 1].Cells["status"].Style = new DataGridViewCellStyle { ForeColor = Color.Green };
                        break;
                    case 2:
                        this.dataGridLista.Rows[dataGridLista.RowCount - 1].Cells["status"].Style = new DataGridViewCellStyle { ForeColor = Color.Orange };
                        break;
                    default:
                        break;
                }

            }
        }

        private void DialogMessage(string message, string caption, int type)
        {

            switch (type)
            {
                case 0:
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }

        }

        private string GetResult(string strIPAddress, string strHostName)
        {
            var request = (HttpWebRequest)WebRequest.Create("http://" + strIPAddress);
            request.Host = strHostName;

            request.Credentials = CredentialCache.DefaultCredentials;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content. 
            string responseFromServer = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }
        private void StartProcess()
        {

            this.passed = true;

            for (int i = 0; i < this.list.Count; i++) //Set all redirects to false in order to compare
            {
                this.list[i].Passed = 0;
                this.list[i].Result = "";
            }

            if (!this.chkLive.Checked) //Live or staging test//
            {
                if (!this.CheckIP(this.txtIp.Text))
                {
                    this.DialogMessage("The selected IP is not reachable. Please use a valid IP to test.", "ERROR", 1);
                    return;
                }
                else
                {
                    //this.WriteHosts();
                    this.WriteHostsTest();
                }

            }
            this.Enabled = false;
            this.LoadingPanel(false, this.chkBrowser.Checked); //don't hide browser label
            this.loading.pgrBar.Step = 1;
            this.loading.pgrBar.Value = 0;
            this.loading.pgrBar.Minimum = 0;
            this.loading.pgrBar.Maximum = this.list.Count * 3;
            this.brgwLoading.RunWorkerAsync(); //Start checking URLs in the background worker
        }

        private void PrintURLS()
        {
            HttpWebRequest myHttpWebRequest = null;
            HttpWebResponse myHttpWebResponse = null;
            for (int i = 0; i < this.list.Count; i++)
            {
                try
                {
                    Uri myUri = new Uri(this.list[i].Origin);
                    myHttpWebRequest = (HttpWebRequest)WebRequest.Create(myUri);
                    myHttpWebRequest.AllowAutoRedirect = false;
                    myHttpWebRequest.UserAgent = ".NET Framework Test Client";
                    myHttpWebRequest.Timeout = 3000;
                    myHttpWebRequest.ReadWriteTimeout = 3000;
                    if (this.chkV2.Checked)
                    {
                        myHttpWebRequest.Headers["v2header"] = "true";
                    }
                    else;
                    myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                    Console.WriteLine("------------------\nResponse: " + myHttpWebResponse.StatusCode);
                    Console.WriteLine("Origin: " + myHttpWebRequest.Address.ToString());
                    Console.WriteLine("Destiny: " + myHttpWebResponse.ResponseUri);
                    myHttpWebResponse.Close();
                }
                catch (System.Net.WebException error)
                {
                    Console.WriteLine("Error: ", error.Message.ToString());
                }

            }

        }

        public void SeleniumChromeCheck() //Start checking the URLs using selenium
        {
            this.DriverCheckUrls();
            this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
            {
                this.loading.lblStatus.Text = "Comparing URLs";
            });
            for (int i = 0; i < this.list.Count; i++)
            {

                Console.WriteLine(this.list[i].Response);
                if ((this.list[i].Response == 301) || (this.list[i].Response == 302))
                {

                    if (this.list[i].Destiny.Equals(this.list[i].ServerDestiny, StringComparison.InvariantCultureIgnoreCase))
                    {
                        if (this.list[i].Response == this.response) // Compare response code
                        {
                            this.list[i].Passed = 1;
                            this.list[i].Result += "All Ok";
                        }
                        else
                        {
                            this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
                            {
                                ModifyProgressBarColor.SetState(this.loading.pgrBar, 2); //Changes progress bar to red
                            });
                            this.list[i].Result += "Wrong response code";
                            this.passed = false;
                        }

                    }
                    else
                    {
                        this.list[i].Result += "Destiny URL does not match (" + this.list[i].ServerDestiny + ")";
                        this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
                        {
                            ModifyProgressBarColor.SetState(this.loading.pgrBar, 2); //Changes progress bar to red
                        });

                        this.passed = false;

                    }

                }

                else
                {
                    this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
                    {
                        ModifyProgressBarColor.SetState(this.loading.pgrBar, 2); //Changes progress bar to red
                    });
                    switch (this.list[i].Response)
                    {
                        case 200:
                            this.list[i].Result = "Redirect does not exist";
                            break;
                        case 404:
                            this.list[i].Result = "Could not reach destiny URL";
                            break;

                        default:
                            this.list[i].Result = "URL was not tested";
                            break;
                    }
                    this.passed = false;

                }

                this.UpdatePgrBar();
            }
        }

        private void DriverCheckUrls()
        {
            this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
            {
                this.loading.lblStatus.Text = "Checking URLs";
            });
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true; //Initialices Chrome driver on background
            ChromeOptions option = new ChromeOptions(); 

            if (this.chkBrowser.Checked)
                option.AddArgument("--start-maximized"); //Show Browser
            else
                option.AddArgument("--headless");  // Hide Browser
            driver = new ChromeDriver(driverService, option);
            for (int i = 0; i < this.list.Count; i++)
            {
                try
                {
                    this.driver.Navigate().GoToUrl(this.list[i].Origin);
                    this.list[i].ServerDestiny = this.driver.Url;
                }
                catch (OpenQA.Selenium.WebDriverException)
                {
                    this.list[i].ServerDestiny = "Can not reach URL due to timeout exception";
                }
                Console.WriteLine("Origin: " + this.list[i].Origin);
                Console.WriteLine("Destiny: " + this.list[i].Destiny);
                Console.WriteLine("Server Destiny: " + this.list[i].ServerDestiny);
                Console.WriteLine("Response: " + this.list[i].Response);
                this.UpdatePgrBar();
            }


            this.driver.Quit();
        }

        public bool CheckIP(string ip)
        {
            try
            {
                Ping ping = new Ping();
                PingReply pingReply = ping.Send(ip);

                if (pingReply.Status == IPStatus.Success)
                {
                    Console.WriteLine("OK: " + pingReply.Status);
                    return true;
                }
                else
                {
                    Console.WriteLine("Wrong: " + pingReply.Status);
                    return false;
                }
            }
            catch (System.Net.NetworkInformation.PingException)
            {
                return false;
            }
        }

        private void LoadingPanel(bool hidePgr, bool hideBrowser)
        {
            this.loading = new LoadingForm(hidePgr, hideBrowser);
            this.loading.Enabled = true;
            this.loading.Visible = true;
            this.loading.Location = this.Location;
            this.loading.Update();
            this.loading.Refresh();
            Application.DoEvents();

        }

        private void HidePanel()
        {
            this.loading.Close();
        }

        private void CopyClipboard()
        {
            try
            {
                if (this.ClipBoardLoad())
                {

                    Console.WriteLine(this.list.Count);
                    this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
                    {
                        this.dataGridLista.Rows.Clear();
                        this.txtUrl.Text = this.GetDomain(this.list[0].Origin);
                        this.domainName = this.txtUrl.Text;
                        this.loading.lblStatus.Text = "Retrieving URLs from clipboard";
                    });
                    this.redirectsLoaded = true;
                    this.DialogMessage("URLs added! Ready to start testing!", "INFO MESSAGE", 0);
                    this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
                    {
                        this.FillGrid();
                        this.HidePanel();
                        this.Enabled = true;
                    });
                }

                else
                {
                    this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
                    {
                        this.HidePanel();
                        this.Enabled = true;
                    });
                }

            }
            catch (System.Exception clipException)
            {
                this.DialogMessage(clipException.ToString(), "ERROR MESSAGE", 1);
                this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
                {
                    this.HidePanel();
                    this.Enabled = true;
                });
            }

        }

        //Methods end

        // Events begin

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.dialogOpenFile.ShowDialog();
            this.config.FilePath = this.dialogOpenFile.FileName;
            Console.WriteLine(this.config.FilePath);
            this.LoadCSV();
        }

        private void txtClipboard_Click(object sender, EventArgs e)
        {
            this.LoadingPanel(true, false); //Hide browser label and progress bar
            this.bgrwCopy.RunWorkerAsync();
        }

        private void radioPermanent_CheckedChanged(object sender, EventArgs e)
        {
            this.permanentRedirect = true;
            this.response = 301;
            Console.WriteLine(this.permanentRedirect);
        }

        private void radioTemporary_CheckedChanged(object sender, EventArgs e)
        {
            this.permanentRedirect = false;
            this.response = 302;
            Console.WriteLine(this.permanentRedirect);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.redirectsLoaded)
            {
                this.StartProcess();
            }
            else
            {
                this.DialogMessage("Please load the redirects first.", "ERROR", 1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void brgwLoading_DoWork(object sender, DoWorkEventArgs e) //Check the URLs in a background worker
        {
            this.GetResponse();
            this.SeleniumChromeCheck();
            if (!this.chkLive.Checked)
            {
                this.DeleteLastLine();
            }
            this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
            {
                this.loading.lblStatus.Text = "Done!";
            });

            if (!this.passed)
                this.DialogMessage("Redirects were successfully tested.\nISSUES FOUND", "INFO MESSAGE", 2);
            else;

            /*if (this.passed)
                this.DialogMessage("Redirects were successfully tested.\nALL OK!", "INFO MESSAGE", 0);
            else
                this.DialogMessage("Redirects were successfully tested.\nISSUES FOUND", "INFO MESSAGE", 2);*/
            this.Invoke((MethodInvoker)delegate () //GUI handler outside GUI's Thread
            {
                this.FillGrid();
                this.HidePanel();
                this.Enabled = true;

                //Brings form to the front
                if (this.WindowState == FormWindowState.Minimized)
                    this.WindowState = FormWindowState.Normal;

                this.Show();
                this.Activate();
                this.ShowInTaskbar = true;
                this.TopMost = true;
                this.Focus();
                this.TopMost = false;
                //Brings form to the front
            });



        }

        private void bgrwCopy_DoWork(object sender, DoWorkEventArgs e) //Uses a background worker to add the URLs from the clipboard
        {
            this.CopyClipboard();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.config.DocumentationUrl);
        }

        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            this.toolTipHelp.SetToolTip(btnHelp, "Need Help? Click to open the documentation");
        }
    }
    //Events end





    public static class ModifyProgressBarColor  //Changes color of progress bar
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
