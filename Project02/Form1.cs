// Author: Jonathan Spalding
// Assignment: Project 2
// Instructor "Roger deBry
// Clas: CS 1400
// Date Written: 1/31/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The splitTheGold_Click Method
        // Purpose: give 12% of gold to Jack, 8% to his first mate, and 
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void splitTheGold_Click(object sender, EventArgs e)
        {
            //State any constants
            const double JACKSTASH = .12;
            const double MATESHARE = .08;
            //convert input for both crew members and gold to double
            double crew = double.Parse(numOfPiratesInput.Text);
            double gold = double.Parse(numOfGold.Text);
            //Hand out 3 coins to each member so they can party.
            gold = gold - (crew - 2) * 3;
            //find 12% of gold for jack
            double jack = Math.Floor(gold * JACKSTASH);
            gold = gold - jack;
            //then find 8% of the remaining gold for is first Mate.
            double mate = Math.Floor(gold * MATESHARE);
            gold = gold - mate;
            //divide remaining gold by number of crew members
            double finalShare = Math.Floor(gold / crew);
            //find the modulus to put the remainder in the Pirate's Benevolent Association
            double leftOvers = gold % crew;
            //convert totals into strings
            string jackTotal = $"{jack}";
            string mateTotal = $"{mate}";
            string crewMemberTotal = $"{finalShare}";
            string benevolentFundTotal = $"{leftOvers}";
            //output in each of the output boxes
            jacksShare.Text = jackTotal;
            matesShare.Text = mateTotal;
            crewMembersShare.Text = crewMemberTotal;
            piratesBenevolentFund.Text = benevolentFundTotal;
        }

        // The exitToolStripMenuItem1_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The aboutToolStripMenuItem_Click Method
        // Purpose: Display a pop up box when you click About
        // Parameters: The sending object, and the event arguments
        // Returns: none
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jonathan Spalding\nCS1400\nProject 2");
        }
    }
}
