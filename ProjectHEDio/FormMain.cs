﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace ProjectHEDio
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        public FormMain()
        {
            InitializeComponent();

            // Do this thing
            comboBoxLanguageSelector.Text = "English";

            // Set progress bar to have a value to allow marquee style
            progressBarMain.Value = 0;

            // Workaround for text box to have prompt text
            textBoxTags.Text = "Test :3c";
            textBoxTags.Text = "";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxUseTags_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUseTags.Checked)
            {
                textBoxTags.Enabled = true;
            }
            else
            {
                textBoxTags.Clear();
                textBoxTags.Enabled = false;
            }
        }

        private void checkBoxRestrictImageSizes_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = checkBoxRestrictImageSizes.Checked;
            panelRestrictImageSizes.Enabled = enabled;
            panelRestrictImageSizesMethod.Enabled = enabled;
            numericUpDownRestrictImageSizesWidth.Enabled = enabled;
            numericUpDownRestrictImageSizesHeight.Enabled = enabled;
            if (enabled)
            {
                radioButtonRestrictImageSizesEqual.Checked = true;
                radioButtonRestrictImageSizesMethodManual.Checked = true;
            }
            else
            {
                foreach (Control c in panelRestrictImageSizes.Controls)
                {
                    if (c is MetroRadioButton)
                    {
                        MetroRadioButton m = (MetroRadioButton)c;
                        m.Checked = false;
                    }
                }
                foreach (Control c in panelRestrictImageSizesMethod.Controls)
                {
                    if (c is MetroRadioButton)
                    {
                        MetroRadioButton m = (MetroRadioButton)c;
                        m.Checked = false;
                    }
                    if (c is MetroCheckBox)
                    {
                        MetroCheckBox m = (MetroCheckBox)c;
                        m.Checked = false;
                    }
                }
            }
        }
    }
}
