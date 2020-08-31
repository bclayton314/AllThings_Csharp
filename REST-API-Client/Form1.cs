﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpRESTClient
{
    public partial class cmdGO : Form
    {
        public cmdGO()
        {
            InitializeComponent();
        }

        #region UI Event Handlers

        private void cmdGO1_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = txtRequestURI.Text;
            rClient.authTech = authenticationTechnique.RollYourOwn;
            rClient.authType = authenticationType.Basic;
            rClient.userName = txtUserName.Text;
            rClient.userPassword = txtPassword.Text;

            debugOutput("Rest Client Created");

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            debugOutput(strResponse);
        }

        #endregion

        private void debugOutput(string strDebugText)
        { 
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        
    }
}
