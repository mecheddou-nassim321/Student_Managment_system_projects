using System;
using System.Windows.Forms;

namespace Student_Mnagment_System
{
    public partial class Fr_Mdemy_School : Form
    {
        public Fr_Mdemy_School()
        {
            InitializeComponent();
        }

        private void ResetDashboard()
        {
            listView2.Visible = true;
            listView3.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            listView4.Visible = false;
            listView5.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
        }

        private void Fr_Mdemy_School_Load(object sender, EventArgs e)
        {
            ResetDashboard();
        }

        // ***********************
        //     STUDENT CRUD
        // ***********************

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
                return;

            var selected = listView3.SelectedItems[0];

            Name_text.Text = selected.Text;
            First_Name_text.Text = selected.SubItems[1].Text;
            email_text.Text = selected.SubItems[2].Text;
            phone_text.Text = selected.SubItems[3].Text;
            dateTimePicker1.Text = selected.SubItems[4].Text;

            if (selected.SubItems[5].Text == rb_male.Text)
                rb_male.Checked = true;
            else
                rb_female.Checked = true;
        }

       

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
                return;

            var selected = listView3.SelectedItems[0];

            selected.Text = Name_text.Text;
            selected.SubItems[1].Text = First_Name_text.Text;
            selected.SubItems[2].Text = email_text.Text;
            selected.SubItems[3].Text = phone_text.Text;
            selected.SubItems[4].Text = dateTimePicker1.Text;
            selected.SubItems[5].Text = rb_male.Checked ? rb_male.Text : rb_female.Text;

            ClearStudentForm();
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
                listView3.Items.Remove(listView3.SelectedItems[0]);
        }

        private void ClearStudentForm()
        {

            text_ID_Student.Clear();
            text_firste_name.Clear();
            text_last_name.Clear();
            textBox6.Clear();
        }


        // ***********************
        //       COURSES CRUD
        // ***********************

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 0)
                return;

            var selected = listView4.SelectedItems[0];

            course_id_text.Text = selected.Text;
            course_name_text.Text = selected.SubItems[1].Text;
            course_hour_text.Text = selected.SubItems[2].Text;
            Description_rich_text.Text = selected.SubItems[3].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(course_id_text.Text.Trim());
            item.SubItems.Add(course_name_text.Text.Trim());
            item.SubItems.Add(course_hour_text.Text.Trim());
            item.SubItems.Add(Description_rich_text.Text.Trim());

            listView4.Items.Add(item);
            ClearCourseForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 0)
                return;

            var selected = listView4.SelectedItems[0];

            selected.Text = course_id_text.Text;
            selected.SubItems[1].Text = course_name_text.Text;
            selected.SubItems[2].Text = course_hour_text.Text;
            selected.SubItems[3].Text = Description_rich_text.Text;

            ClearCourseForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count > 0)
                listView4.Items.Remove(listView4.SelectedItems[0]);
        }

        private void ClearCourseForm()
        {
            course_id_text.Clear();
            course_name_text.Clear();
            course_hour_text.Clear();
            Description_rich_text.Clear();
        }


        // ***********************
        //       SCORE CRUD
        // ***********************

       

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(text_ID_Student.Text.Trim());
            item.SubItems.Add(text_firste_name.Text.Trim());
            item.SubItems.Add(text_last_name.Text.Trim());
            item.SubItems.Add(textBox6.Text.Trim());

            listView5.Items.Add(item);
            ClearScoreForm();
        }

         
        

      

        private void ClearScoreForm()
        {
            text_ID_Student.Clear();
            text_firste_name.Clear();
            text_last_name.Clear();
            textBox6.Clear();
        }


        // ***********************
        //       NAVIGATION
        // ***********************

        private void Student_label_Click(object sender, EventArgs e)
        {
            listView2.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            listView4.Visible = false;

            listView3.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;

            panel3.BringToFront();
            panel4.BringToFront();
            listView3.BringToFront();
        }

        private void course_label_Click(object sender, EventArgs e)
        {
            // Hide all non-Course views
            listView2.Visible = false; // Dashboard background
            panel3.Visible = false;    // Student main panel
            panel4.Visible = false;    // Student CRUD panel

            // Show the main Course/Score container
            panel5.Visible = true;

            // Show Course-specific panels
            panel6.Visible = true;     // Course header (title)
            panel8.Visible = true;     // Course management/CRUD panel
            listView4.Visible = true;  // Course list

            // Hide Score-specific panels
            panel7.Visible = false;
            listView5.Visible = false;

            // Bring the Course area to the front
            panel5.BringToFront();
        }

        private void Score_label_Click(object sender, EventArgs e)
        {
            // Hide all non-Score views
            listView2.Visible = false; // Dashboard background
            panel3.Visible = false;    // Student main panel
            panel4.Visible = false;    // Student CRUD panel

            // Show the main Course/Score container
            panel5.Visible = true;

            // Show Score-specific panels
            panel7.Visible = true;     // Score management/CRUD panel
            listView5.Visible = true;  // Score list

            // Hide Course-specific panels
            panel6.Visible = false;    // Course header
            panel8.Visible = false;    // Course management/CRUD panel
            listView4.Visible = false; // Course list

            // Bring the Score area to the front
            panel5.BringToFront();
        }
        private void Dashboard_label_Click(object sender, EventArgs e)
        {
            ResetDashboard();
        }

        private void Exit_label_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_delet_student_Click_1(object sender, EventArgs e)
        {
            if (listView5.SelectedItems.Count > 0)
                listView5.Items.Remove(listView5.SelectedItems[0]);

        }

        private void btn_add_student_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_ID_Student.Text) ||
                string.IsNullOrEmpty(text_firste_name.Text) ||
                string.IsNullOrEmpty(text_last_name.Text) ||
                string.IsNullOrEmpty(textBox6.Text))
                return;

            ListViewItem item = new ListViewItem(text_ID_Student.Text.Trim());
            item.SubItems.Add(text_firste_name.Text.Trim());
            item.SubItems.Add(text_last_name.Text.Trim());
            item.SubItems.Add(textBox6.Text.Trim());
          

            listView5.Items.Add(item);
            ClearStudentForm();
        }

        private void btn_update_student_Click_1(object sender, EventArgs e)
        {
            if (listView5.SelectedItems.Count == 0)
                return;

            var selected = listView5.SelectedItems[0];

            selected.Text = text_ID_Student.Text;
            selected.SubItems[1].Text = text_firste_name.Text;
            selected.SubItems[2].Text = text_last_name.Text;
            selected.SubItems[3].Text = textBox6.Text;

            ClearScoreForm();
        }

        private void listView5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView5.SelectedItems.Count == 0)
                return;

            var selected = listView5.SelectedItems[0];

            text_ID_Student.Text = selected.Text;
            text_firste_name.Text = selected.SubItems[1].Text;
            text_last_name.Text = selected.SubItems[2].Text;
            textBox6.Text = selected.SubItems[3].Text;
        }
    }
}
