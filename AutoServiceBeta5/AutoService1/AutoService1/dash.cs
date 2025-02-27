﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using MySql.Data.MySqlClient;

namespace AutoService1
{
    public partial class dash : UserControl
    {
        string connectionString = @"server=localhost;Uid=root;database=autoservice;port=3306;password=qweqwe1234";
        static string[] Scopes = { CalendarService.Scope.CalendarReadonly };
        static string ApplicationName = "Google Calendar API .NET Quickstart";
        public dash()
        {
            InitializeComponent();
            GoogleAPI();
            nrKlientave();
            nrServisave();
        }
        private void GoogleAPI()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("primary");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 5;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            // List events.
            Events events = request.Execute();
            if (events.Items != null && events.Items.Count > 0)
            {
                CalendarEvents.Text = "";
                label5.Text = "";
                foreach (var eventItem in events.Items)
                {
                    CalendarEvents.Text += eventItem.Summary + Environment.NewLine;
                    label5.Text += eventItem.Start.DateTime + Environment.NewLine;
                }
            }
            else
            {
                CalendarEvents.Text = "Nuk ka ngjarje";
                label5.Text = "Data";
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dash_Load(object sender, EventArgs e)
        {
 
        }

        private void GetEvents_Tick(object sender, EventArgs e)
        {
            GoogleAPI();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        void nrServisave()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                try
                {
                    MySqlCommand cmd = mysqlCon.CreateCommand();
                    cmd.CommandText = "SELECT COUNT(*)FROM servisi;";
                    mysqlCon.Open();

                    int vlera = int.Parse(cmd.ExecuteScalar().ToString());
                    label3.Text = vlera.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                mysqlCon.Close();

            }
        }

        void nrKlientave()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {

                try { 
                MySqlCommand cmd = mysqlCon.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*)FROM cars;";
                mysqlCon.Open();

                int vlera = int.Parse(cmd.ExecuteScalar().ToString());
                label2.Text = vlera.ToString();
                
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                mysqlCon.Close();

            }
        }
    }
}
