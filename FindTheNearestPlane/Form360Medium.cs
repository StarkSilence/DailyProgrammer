using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Dynamic;

namespace Challenge360Medium
{
    public partial class Form360Medium : Form
    {
        private const string PlaneDataFile = @"PlaneData.json";

        private class AllPlaneData
        {
            public int time { get; set; }
            public dynamic[][] states { get; set; }
        }

        public Form360Medium()
        {
            InitializeComponent();
            ComboNorthSouth.SelectedIndex = 0;
            ComboEastWest.SelectedIndex = 0;
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            double latitudePosition = GetLatitude();
            double longitudePosition = GetLongitude();

            DownloadPlaneData();
            AllPlaneData planeData = ReadPlaneData();

            int closestPlane = 0;
            double closestPlaneDistance = getDistance(latitudePosition, longitudePosition, planeData.states[0][6], planeData.states[0][5]);
            for (int i = 1, numOfPlanes = planeData.states.Length; i < numOfPlanes; i++)
            {
                double? latitudePlane = planeData.states[i][6];
                double? longitudePlane = planeData.states[i][5];
                if (latitudePlane == null || longitudePlane == null)
                    continue;

                double distance = getDistance(latitudePosition, longitudePosition, (double)latitudePlane, (double)longitudePlane);

                if (distance < closestPlaneDistance)
                {
                    closestPlane = i;
                    closestPlaneDistance = distance;
                }
            }

            OutputClosestPlane(planeData.states[closestPlane], closestPlaneDistance);
        }

        private double getDistance(double latitudePosition, double longitudePosition, double latitudePlane, double longitudePlane)
        {
            return Math.Sqrt(Math.Pow(latitudePlane - latitudePosition, 2) + Math.Pow(longitudePlane - longitudePosition, 2));
        }

        private double GetLatitude()
        {
            string input = TxtLatitude.Text;
            double latitude;

            if (!double.TryParse(input, out latitude))
                throw new Exception("Invalid input");
            else if (latitude < 0 || latitude >= 90)
                throw new Exception("Latitude must be at least 0 and less than 90");
            else if (ComboNorthSouth.SelectedItem as string == "S")
                latitude *= -1;

            return latitude;
        }

        private double GetLongitude()
        {
            string input = TxtLongitude.Text;
            double longitude;

            if (!double.TryParse(input, out longitude))
                throw new Exception("Invalid input");
            else if (longitude < 0 || longitude >= 180)
                throw new Exception("Longitude must be at least 0 and less than 180");
            else if (ComboEastWest.SelectedItem as string == "W")
                longitude *= -1;

            return longitude;
        }

        private void DownloadPlaneData()
        {
            string downloadAddress = "https://opensky-network.org/api/states/all";

            using (var client = new WebClient())
            {
                client.DownloadFile(downloadAddress, PlaneDataFile);
            }
        }

        private AllPlaneData ReadPlaneData()
        {
            using (StreamReader file = new StreamReader(PlaneDataFile))
            {
                return JsonConvert.DeserializeObject<AllPlaneData>(file.ReadToEnd());
            }
        }

        private void OutputClosestPlane(object[] closestPlane, double distance)
        {
            ListOutput.Items.Clear();

            ListOutput.Items.Add(distance);
            ListOutput.Items.Add(closestPlane[1]);
            ListOutput.Items.Add("Latitude: " + closestPlane[6].ToString());
            ListOutput.Items.Add("Longitude: " + closestPlane[5].ToString());
            ListOutput.Items.Add("Altitude: " + closestPlane[7]);
            ListOutput.Items.Add("From: " + closestPlane[2]);
            ListOutput.Items.Add(closestPlane[0]);
        }
    }
}
