﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    /**
     * Hospital form
     * The main menu of the App
     * Including 5 buttons to point to the sub-menu
     * 
     */
    public partial class Hospital : Form
    {
        public static List<Patient> patients = new List<Patient>();

        public Hospital()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        // Show long term patient
        private void button1_Click(object sender, EventArgs e)
        {
            LongTerm_Day_Patient patient = new LongTerm_Day_Patient(this);
            patient.Show();
            patient.ShowLongTermDayPatients(button1.Name);
            this.Hide();
            
        }

        // Show day patient
        private void button2_Click(object sender, EventArgs e)
        {
            LongTerm_Day_Patient patient = new LongTerm_Day_Patient(this);
            patient.Show();
            patient.ShowLongTermDayPatients(button2.Name);
            this.Hide();
        }

        // New patient
        private void button3_Click(object sender, EventArgs e)
        {
            NewPatient newPatientForm = new NewPatient(this);
            this.Hide();
            newPatientForm.Show();
        }
        
        // Update patient
        private void button4_UpdatePatient_Click(object sender, EventArgs e)
        {
            UpdatePatient  updatePatient = new UpdatePatient(this);
            this.Hide();
            updatePatient.Show();
            updatePatient.ShowAllPatients();
        }

        // Discharged patient
        private void button5_DischargedPatient_Click(object sender, EventArgs e)
        {
            DischargedPatient dPatient = new DischargedPatient(this);
            this.Hide();
            dPatient.Show();
            dPatient.ShowDischargedPatients();
        }

        // Mouse hover effects on button
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        // Mouse hover effects on button
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        // Mouse hover effects on button
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        // Mouse hover effects on button
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        // Mouse hover effects on button
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4_UpdatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center; 
        }

        // Mouse hover effects on button
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4_UpdatePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        // Mouse hover effects on button
        private void button5_DischargedPatient_Click_MouseEnter(object sender, EventArgs e)
        {
            button5_DischargedPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        // Mouse hover effects on button
        private void button5_DischargedPatient_Click_MouseLeave(object sender, EventArgs e)
        {
            button5_DischargedPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        // Mouse hover effects on button
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        }

        // Mouse hover effects on button
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }
    }
}
