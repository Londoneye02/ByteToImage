﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteToImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button2_Click(object sender, EventArgs e)



        {


            int[] Comparar1 = new int[] { 1, 2, 4, 8, 16, 32, 64, 128 };
            int[] Comparar = new int[] { 128, 64, 32, 16, 8, 4, 2, 1 };
            /* Imagen WIFI
            int[] byteImagenes = new int[] { 0xff, 0xfe, 0x07, 0xff, 0xff, 0xff, 0x00, 0x0f, 0xff, 0xff, 0xe0, 0x00, 0x3f, 0xff, 0xf8, 0x00, 0x01, 0xff, 0xff, 0x00, 0x00, 0x0f, 0xfe, 0x00, 0x00, 0x00, 0x07, 0x80, 0x00, 0x00, 0x00, 0x18, 0x00, 0x00, 0x7f, 0xf1, 0x00, 0x00, 0x0f, 0xff, 0x81, 0x99, 0xb1, 0x80, 0x9c, 0x19, 0x9b, 0x18, 0x09, 0xc0, 0x99, 0x31, 0x9f, 0x9c, 0x0f, 0xf0, 0x19, 0xff, 0xc0, 0xff, 0x31, 0x81, 0x9c, 0x0f, 0xf3, 0x18, 0x19, 0xc0, 0xe7, 0x31, 0x9f, 0x9c, 0x06, 0x63, 0x19, 0xf9, 0xc0, 0x66, 0x31, 0x9f, 0x9c, 0x00, 0x00, 0x1f, 0xff, 0xc0, 0x00, 0x03, 0xff, 0xf8, 0x80, 0x00, 0x7f, 0xff, 0x18, 0x00, 0x00, 0x00, 0x01, 0xe0, 0x00, 0x00, 0x00, 0x7f, 0xe0, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0x1f, 0xff, 0xfc, 0x00, 0x03, 0xff, 0xff, 0xe0, 0x00, 0xff, 0xff, 0xff, 0x80, 0x3f, 0xff};
            

            int ImageLength = 36;
            int ImageBytes = 126;
            */
            /* Mixer
            int[] byteImagenes = new int[] { 0xe0, 0x00, 0x00, 0x1f, 0x00, 0x00, 0x00, 0x38, 0x00, 0x00, 0x00, 0x40, 0x00, 0x00, 0x00, 0x0f, 0xff, 0xff, 0xc0, 0x3f, 0xff, 0xff, 0x00, 0xf9, 0xfe, 0x7c, 0x03, 0xe7, 0xf9, 0xf0, 0x0f, 0x9f, 0xe7, 0xc0, 0x3c, 0x3f, 0x9f, 0x00, 0xe0, 0x7e, 0x7c, 0x03, 0x81, 0xf9, 0xf0, 0x0e, 0x07, 0xe7, 0xc0, 0x38, 0x1f, 0x9f, 0x00, 0xf0, 0xfe, 0x7c, 0x03, 0xe7, 0xf0, 0xf0, 0x0f, 0x9f, 0x81, 0xc0, 0x3e, 0x7e, 0x07, 0x00, 0xf9, 0xf8, 0x1c, 0x03, 0xe7, 0xe0, 0x70, 0x0f, 0x9f, 0xc3, 0xc0, 0x3e, 0x7f, 0x9f, 0x00, 0xf9, 0xfe, 0x7c, 0x03, 0xe7, 0xf9, 0xf0, 0x0f, 0xff, 0xff, 0xc0, 0x3f, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x01, 0xc0, 0x00, 0x00, 0x0f, 0x80, 0x00, 0x00, 0x70};
            int ImageLength = 30;
            int ImageBytes = 113;
            */



            /*SpkOff
        int[] byteImagenes = new int[] {0xff, 0xff, 0xff, 0xff, 0xff, 0xfc, 0xff, 0xff, 0xff, 0xc3, 0xff, 0xff, 0xfc, 0x0f, 0xff, 0xc1, 0xe0, 0x3f, 0xfe, 0x06, 0x00, 0xff, 0xf8, 0x18, 0x03, 0xff, 0xe0, 0x60, 0x0f, 0xff, 0x81, 0x80, 0x3f, 0xfe, 0x06, 0x00, 0xff, 0xf8, 0x18, 0x03, 0xff, 0xe0, 0x60, 0x0f, 0xff, 0x81, 0x80, 0x7f, 0xfe, 0x06, 0x02, 0x3f, 0x88, 0x18, 0x08, 0x7c, 0x20, 0x60, 0x30, 0xe1, 0x81, 0x80, 0x61, 0x0e, 0x06, 0x00, 0xc0, 0x78, 0x18, 0x03, 0x83, 0xf0, 0x70, 0x0e, 0x0f, 0xff, 0xf0, 0x30, 0x1f, 0xff, 0xf1, 0x84, 0x3f, 0xff, 0xec, 0x38, 0x7f, 0xff, 0xe1, 0xf0, 0xff, 0xff, 0x8f, 0xe0};

        int ImageLength = 30;
        int ImageBytes = 94;
        */

            //Spkon
            /*
            int[] byteImagenes = new int[] { 0xff, 0xff, 0xff, 0xff, 0xff, 0xfc, 0xff, 0xff, 0xff, 0xc3, 0xff, 0xff, 0xfc, 0x0f, 0xcf, 0xc1, 0xe0, 0x3f, 0x1e, 0x06, 0x00, 0xfe, 0x38, 0x18, 0x03, 0x3c, 0xe0, 0x60, 0x0e, 0x71, 0x81, 0x80, 0x3c, 0xe6, 0x06, 0x00, 0xf1, 0x98, 0x18, 0x06, 0xe6, 0x60, 0x60, 0x19, 0x99, 0x81, 0x80, 0x66, 0x66, 0x06, 0x01, 0xb9, 0x98, 0x18, 0x03, 0xc6, 0x60, 0x60, 0x0f, 0x39, 0x81, 0x80, 0x39, 0xe6, 0x06, 0x00, 0xcf, 0x38, 0x18, 0x03, 0xf8, 0xf0, 0x70, 0x0f, 0xc7, 0xff, 0xf0, 0x3f, 0x3f, 0xff, 0xf0, 0xff, 0xff, 0xff, 0xe3, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfc };

            int ImageLength = 30;
            int ImageBytes = 94;*/


            /*//World 
 int[] byteImagenes = new int[] {0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x13, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x3e, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x81, 0xf8, 0x1f, 0xe1, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x0f, 0xff, 0x0f, 0xfc, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x3f, 0xff, 0x07, 0xcf, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x7f, 0xbe, 0x03, 0x81, 0x83, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x81, 0x60, 0x00, 0x00, 0xc0, 0x81, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x0e, 0x00, 0x01, 0xfc, 0x10, 0x00, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x1e, 0x00, 0x03, 0xfe, 0x3c, 0x00, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x3c, 0xf9, 0x07, 0xff, 0x3e, 0x00, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0xf7, 0xfe, 0x07, 0xff, 0xff, 0x80, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x83, 0x86, 0xff, 0x07, 0xff, 0xff, 0xc0, 0x01, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x06, 0x71, 0x30, 0x07, 0xff, 0xff, 0xf0, 0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x00, 0x7e, 0x00, 0x03, 0xff, 0xff, 0xf8, 0x00, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x00, 0x7b, 0x00, 0x03, 0xff, 0xff, 0xfc, 0x00, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x01, 0xf8, 0x00, 0x01, 0xff, 0xff, 0xfe, 0x00, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x3f, 0xf0, 0x00, 0x00, 0xff, 0xff, 0xff, 0x90, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe0, 0x0f, 0xf0, 0x00, 0x00, 0x7f, 0xff, 0xff, 0x98, 0x07, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x0f, 0xf0, 0x00, 0x00, 0xff, 0xff, 0xff, 0x88, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x0f, 0xf9, 0x30, 0x00, 0x3f, 0xff, 0xff, 0x8e, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x80, 0x1f, 0xff, 0xf8, 0x00, 0x1f, 0xff, 0xff, 0x8f, 0x01, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x7f, 0xff, 0xf0, 0x00, 0x1f, 0xff, 0xff, 0x8f, 0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x20, 0x7f, 0xff, 0xe0, 0x00, 0x07, 0xff, 0xff, 0xc7, 0x00, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x40, 0xfc, 0x7f, 0xc0, 0x00, 0x07, 0xff, 0xff, 0xf3, 0x00, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0xc0, 0xfe, 0x1f, 0x80, 0x00, 0x07, 0xff, 0xff, 0xf3, 0x80, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xfd, 0xd7, 0xe4, 0x1f, 0x00, 0x00, 0x07, 0xff, 0xff, 0xf1, 0xc0, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xf9, 0xf7, 0xc0, 0x00, 0x00, 0x00, 0x01, 0xff, 0xff, 0xf0, 0xc0, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xfb, 0xff, 0xc0, 0x00, 0x00, 0x00, 0x00, 0xff, 0xff, 0xf0, 0xe0, 0x9f, 0xff, 0xff, 0xff, 0xff, 0xf7, 0xff, 0xc0, 0x00, 0x00, 0x48, 0x00, 0x7f, 0xff, 0xf8, 0x61, 0x8f, 0xff, 0xff, 0xff, 0xff, 0xf7, 0xff, 0xc0, 0x00, 0x01, 0xf0, 0x00, 0x07, 0xff, 0xf8, 0x01, 0x8f, 0xff, 0xff, 0xff, 0xff, 0xf7, 0xff, 0xe0, 0x00, 0x0f, 0xc0, 0x00, 0x00, 0x7f, 0xf8, 0x01, 0xcf, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xfa, 0x20, 0x00, 0x1f, 0x80, 0x00, 0x00, 0x0f, 0xf8, 0x03, 0xc7, 0xff, 0xff, 0xff, 0xff, 0xe7, 0xe2, 0x20, 0x00, 0x3f, 0x80, 0x00, 0x00, 0x06, 0x78, 0x03, 0xc7, 0xff, 0xff, 0xff, 0xff, 0xcf, 0x0c, 0x01, 0x00, 0x3f, 0xc0, 0x00, 0x00, 0x00, 0xf8, 0x03, 0xe3, 0xff, 0xff, 0xff, 0xff, 0xce, 0x98, 0x05, 0x01, 0x22, 0x00, 0x00, 0x00, 0x00, 0xf8, 0x03, 0xe3, 0xff, 0xff, 0xff, 0xff, 0xdf, 0x00, 0x01, 0x81, 0x42, 0x00, 0x00, 0x00, 0x00, 0xf8, 0x03, 0xe3, 0xff, 0xff, 0xff, 0xff, 0x9f, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xf8, 0x03, 0xf1, 0xff, 0xff, 0xff, 0xff, 0x9f, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xf0, 0x03, 0xf1, 0xff, 0xff, 0xff, 0xff, 0x9e, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xe0, 0x01, 0xf1, 0xff, 0xff, 0xff, 0xff, 0x9c, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x03, 0xc0, 0x03, 0xf1, 0xff, 0xff, 0xff, 0xff, 0x9c, 0x00, 0x1c, 0x44, 0x00, 0x00, 0x00, 0x02, 0x01, 0x80, 0x03, 0xf1, 0xff, 0xff, 0xff, 0xff, 0x9c, 0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x03, 0xf9, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x0c, 0xc0, 0x00, 0x00, 0x00, 0x07, 0x00, 0x00, 0x03, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x1e, 0x70, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x07, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x1e, 0x40, 0x80, 0x00, 0x00, 0x03, 0xc0, 0x00, 0x07, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x1e, 0x10, 0x80, 0x00, 0x00, 0x00, 0xc0, 0x00, 0x03, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x1f, 0x00, 0x01, 0xe0, 0x00, 0x00, 0x60, 0x00, 0x03, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x1f, 0x80, 0x01, 0xf0, 0x00, 0x00, 0x00, 0x00, 0x07, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x00, 0x30, 0x3e, 0x00, 0x01, 0xf0, 0x00, 0x00, 0x00, 0x00, 0x07, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x00, 0x1c, 0x1c, 0x08, 0x03, 0xf0, 0x00, 0x00, 0x00, 0x00, 0x07, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x00, 0x0e, 0x08, 0x00, 0x03, 0xf8, 0xc0, 0x00, 0x00, 0x00, 0x07, 0xf8, 0xff, 0xff, 0xff, 0xff, 0x80, 0x07, 0x00, 0x60, 0x0f, 0xf8, 0xc0, 0x00, 0x00, 0x00, 0x07, 0xf9, 0xff, 0xff, 0xff, 0xff, 0x80, 0x01, 0xe0, 0x80, 0x0f, 0xff, 0x80, 0x00, 0x00, 0x00, 0x07, 0xf9, 0xff, 0xff, 0xff, 0xff, 0x80, 0x1f, 0xf1, 0x80, 0x0f, 0xff, 0x80, 0x00, 0x00, 0x00, 0x07, 0xf9, 0xff, 0xff, 0xff, 0xff, 0x80, 0x03, 0xfe, 0x00, 0x07, 0xff, 0x80, 0x00, 0x00, 0x00, 0x07, 0xf9, 0xff, 0xff, 0xff, 0xff, 0x80, 0x04, 0xfc, 0x00, 0x0f, 0xff, 0xc0, 0x00, 0x00, 0x00, 0x0f, 0xf9, 0xff, 0xff, 0xff, 0xff, 0x80, 0x03, 0x00, 0x00, 0x0f, 0xff, 0xc0, 0x00, 0x00, 0x00, 0x0f, 0xf9, 0xff, 0xff, 0xff, 0xff, 0x80, 0x00, 0x00, 0x00, 0x07, 0xff, 0xc0, 0x00, 0x00, 0x00, 0x0f, 0xf1, 0xff, 0xff, 0xff, 0xff, 0x80, 0x00, 0x00, 0x00, 0x03, 0xff, 0xe0, 0x00, 0x00, 0x00, 0x0f, 0xf1, 0xff, 0xff, 0xff, 0xff, 0x80, 0x00, 0x00, 0x00, 0x01, 0xff, 0xf8, 0x00, 0x00, 0x00, 0x1f, 0xf1, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x00, 0x00, 0x00, 0xff, 0xe0, 0x00, 0x00, 0x00, 0x1f, 0xf3, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x00, 0x00, 0x00, 0xff, 0xe0, 0x00, 0x00, 0x00, 0x1f, 0xf3, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x00, 0x00, 0x00, 0x7f, 0xc0, 0x00, 0x00, 0x00, 0x1f, 0xe3, 0xff, 0xff, 0xff, 0xff, 0xe0, 0x00, 0x00, 0x00, 0x00, 0xff, 0xc0, 0x00, 0x00, 0x01, 0xff, 0xc7, 0xff, 0xff, 0xff, 0xff, 0xe0, 0x00, 0x00, 0x00, 0x01, 0xff, 0x80, 0x00, 0x00, 0x07, 0xff, 0xc7, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0x00, 0x01, 0xff, 0x8f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x00, 0x01, 0xff, 0xfe, 0x00, 0x00, 0x00, 0x01, 0xff, 0x8f, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x00, 0x01, 0xff, 0xfe, 0x00, 0x00, 0x00, 0x00, 0xff, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x00, 0x00, 0x01, 0xff, 0xfe, 0x00, 0x00, 0x00, 0x00, 0xfc, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x00, 0x00, 0x07, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0xe0, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x00, 0x00, 0x1f, 0xff, 0xff, 0xc0, 0x00, 0x00, 0x00, 0x60, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x00, 0x00, 0x1f, 0xff, 0xff, 0xf0, 0x00, 0x00, 0x00, 0x20, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x00, 0x00, 0x0f, 0xff, 0xff, 0xfc, 0x00, 0x00, 0x00, 0x00, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x00, 0x00, 0x0f, 0xff, 0xff, 0xff, 0x00, 0x00, 0x00, 0x00, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x0f, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x00, 0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x80, 0x00, 0x07, 0xff, 0xff, 0xff, 0xf8, 0x00, 0x00, 0x01, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x00, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x03, 0xff, 0xff, 0xff, 0xff, 0x80, 0x00, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xe0, 0x00, 0x01, 0xff, 0xff, 0xff, 0xff, 0x80, 0x00, 0x07, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x00, 0x7f, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x00, 0x00, 0x3f, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x00, 0x00, 0x3f, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x00, 0x00, 0x07, 0xff, 0xff, 0xff, 0xe0, 0x00, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x00, 0x00, 0x07, 0xff, 0xff, 0xfe, 0x00, 0x00, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x80, 0x00, 0x07, 0xff, 0xff, 0xfe, 0x00, 0x01, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x07, 0xff, 0xff, 0xf0, 0x00, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x01, 0xff, 0xff, 0xf0, 0x00, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf8, 0x00, 0x00, 0x3f, 0xff, 0xf0, 0x00, 0x1f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfc, 0x00, 0x00, 0x03, 0xff, 0xc0, 0x00, 0x3f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x80, 0x00, 0x00, 0x7f, 0x80, 0x01, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x00, 0x00, 0x3f, 0x00, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x00, 0x1c, 0x00, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xfe, 0x00, 0x00, 0x00, 0x00, 0x7f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0x80, 0x00, 0x00, 0x01, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xf0, 0x00, 0x00, 0x0f, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xc0, 0x03, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff};

 int ImageLength = 128;
 int ImageBytes = 2048;*/



            /*  // Wifi2
  int[] byteImagenes = new int[]{
      0x00,0x00,0x00,0x03,
      0x00,0x00,0x00,0x03,
      0x00,0x00,0x00,0x03,
      0x00,0x00,0x00,0x03,
      0x00,0x1f,0xe0,0x03,
      0x00,0xff,0xfc,0x03,
      0x03,0xff,0xff,0x03,
      0x0f,0xc0,0x0f,0xc3,
      0x1f,0x00,0x03,0xe3,
      0x3c,0x00,0x00,0xf3,
      0x78,0x3f,0xf0,0x7b,
      0xe0,0xff,0xfc,0x1f,
      0xe1,0xf8,0x7e,0x1f,
      0x07,0xc0,0x0f,0x83,
      0x07,0x00,0x03,0x83,
      0x0e,0x0f,0xc1,0xc3,
      0x04,0x3f,0xf0,0x83,
      0x00,0x7f,0xf8,0x03,
      0x00,0xf0,0x3c,0x03,
      0x00,0x60,0x18,0x03,
      0x00,0x00,0x00,0x03,
      0x00,0x07,0x80,0x03,
      0x00,0x0f,0xc0,0x03,
      0x00,0x0f,0xc0,0x03,
      0x00,0x07,0x80,0x03,
      0x00,0x03,0x00,0x03,
      0x00,0x00,0x00,0x03,
      0x00,0x00,0x00,0x03,
      0x00,0x00,0x00,0x03,
      0x00,0x00,0x00,0x03,


  };
              int ImageLength = 32;
  int ImageBytes = 120;*/



          /*  // cAMERA 
int[] byteImagenes = new int[]  {
    0x00,0x00,0x00,0x03,
    0x00,0x00,0x00,0x03,
    0x00,0x00,0x00,0x03,
    0x00,0x0f,0xc0,0x03,
    0x00,0x3f,0xf0,0x03,
    0x00,0xff,0xfc,0x03,
    0x01,0xff,0xfe,0x03,
    0x03,0xf0,0x3f,0x03,
    0x03,0xe0,0x09,0x03,
    0x07,0xc7,0x97,0x83,
    0x07,0x89,0xc7,0x83,
    0x07,0xd7,0xeb,0x83,
    0x07,0x1f,0xe3,0xc3,
    0x07,0x1f,0xf3,0xc3,
    0x07,0x1f,0xe3,0xc3,
    0x07,0xdf,0xeb,0x83,
    0x07,0x8f,0xc7,0x83,
    0x07,0xc7,0x8f,0x83,
    0x03,0xe8,0x5f,0x03,
    0x01,0xf0,0x3f,0x03,
    0x01,0xff,0xfe,0x03,
    0x00,0x7f,0xfc,0x03,
    0x00,0x3f,0xf0,0x03,
    0x00,0x07,0x80,0x03,
    0x00,0x60,0x1c,0x03,
    0x00,0xff,0xfc,0x03,
    0x00,0xff,0xfc,0x03,
    0x00,0x00,0x00,0x03,
    0x00,0x00,0x00,0x03,
    0x00,0x00,0x00,0x03,
    
    
};
int ImageLength = 32;
int ImageBytes = 113;
*/


            // Calendar
int[] byteImagenes = new int[] {
0xf3, 0xcf,
    0x92, 0x49,
    0x12, 0x48,
    0x1e, 0x78,
    0x00, 0x00,
    0x00, 0x00,
    0x7f, 0xfe,
    0x66, 0x66,
    0x66, 0x66,
    0x7f, 0xfe,
    0x7f, 0xfe,
    0x66, 0x66,
    0x66, 0x66,
    0x7f, 0xfe,
    0x3f, 0xfc,
    0x80, 0x01
};
int ImageLength = 16;
int ImageBytes = 32;



            /* C
int[] byteImagenes = new int[] 
int ImageLength = 30;
int ImageBytes = 113;
*/
            int rowCounter = 0;
            int columnCounter = 0;


            for (int i = 0; i < ImageBytes; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int mypruebe = byteImagenes[i];
                    int resultado = byteImagenes[i] & Comparar[j];
                    if (resultado == Comparar[j])
                    {
                        CreateBox(columnCounter, rowCounter,15 , true);
                    }
                    else
                    {
                        CreateBox(columnCounter, rowCounter, 15, false);
                    }
                    ++columnCounter;
                    if (columnCounter >= ImageLength)
                    {
                        columnCounter = 0;
                        ++rowCounter;
                    }
                }
            }






        }
        private void CreateBox_PictureBox(int X, int Y, int boxSize, bool Value)
        {
            PictureBox PB = new PictureBox();
            Point PositionPoint = new Point(200 + (X * boxSize), 200 + (Y * boxSize));
            PB.Height = boxSize;
            PB.Width = boxSize;
            PB.Location = PositionPoint;

            if (Value == true)
            {
                PB.BackColor = Color.Black;
            }
            this.Controls.Add(PB);
        }

        private void testBoxGraphics()
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = pictureBox1.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
            myBrush.Dispose();
            formGraphics.Dispose();
            this.Refresh();
        }
        private void CreateBox(int X, int Y, int boxSize, bool Value)
        {

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);

            if (Value)
            {
                myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            }

            Graphics MyGraphics;
            MyGraphics = pictureBox1.CreateGraphics();
            MyGraphics.FillRectangle(myBrush, new Rectangle(X * boxSize, Y * boxSize, boxSize, boxSize));

            /*
            PictureBox PB = new PictureBox();
            Point PositionPoint = new Point(200 + (X * boxSize), 200 + (Y * boxSize));
            PB.Height = boxSize;
            PB.Width = boxSize;
            PB.Location = PositionPoint;

            if (Value == true)
            {
                PB.BackColor = Color.Black;
            }
            this.Controls.Add(PB);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics golfgti6;
            golfgti6 = pictureBox1.CreateGraphics();
            // Pen lapiz = new Pen(Color.Black, 5);
            //golfgti6.DrawEllipse(lapiz, 20, 20, 250, 200);

            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            golfgti6.FillRectangle(myBrush, new Rectangle(50, 50, 5, 5));
        }


    }
}
