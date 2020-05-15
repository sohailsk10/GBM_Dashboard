using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Face_identifcation
{
    public partial class XtraForm_configuration : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm_configuration()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void XtraForm_configuration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aI_DBDataSet.Employee_Video_Link_tbl' table. You can move, or remove it, as needed.
            this.employee_Video_Link_tblTableAdapter.Fill(this.aI_DBDataSet.Employee_Video_Link_tbl);
            // TODO: This line of code loads data into the 'aI_DBDataSet.Employee_Video_Link_tbl' table. You can move, or remove it, as needed.
            this.employee_Video_Link_tblTableAdapter.Fill(this.aI_DBDataSet.Employee_Video_Link_tbl);
            // TODO: This line of code loads data into the 'aI_DBDataSet.Video_List_tbl' table. You can move, or remove it, as needed.
            this.video_List_tblTableAdapter.Fill(this.aI_DBDataSet.Video_List_tbl);
            // TODO: This line of code loads data into the 'aI_DBDataSet.Employee_tbl' table. You can move, or remove it, as needed.
            this.employee_tblTableAdapter.Fill(this.aI_DBDataSet.Employee_tbl);

        }

        private void controlNavigator1_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
           
            if (e.Button.ButtonType.ToString()!="Append"  ) {
                this.Validate();
                this.employee_tblTableAdapter.Update(this.aI_DBDataSet);
                

            }
        }

        private void gridControl1_EmbeddedNavigator_Leave(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_tblTableAdapter.Update(this.aI_DBDataSet);
        }

        private void gridControl1_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Up || e.KeyChar == (char)Keys.Down
                || e.KeyChar == (char)Keys.PageUp || e.KeyChar == (char)Keys.PageDown) {
                this.Validate();
                this.employee_tblTableAdapter.Update(this.aI_DBDataSet);
            }
            if(e.KeyChar == (char)Keys.Insert)
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Append);
            }
            if (e.KeyChar.ToString() == Keys.Delete.ToString())
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Remove);
                this.Validate();
                this.employee_tblTableAdapter.Update(this.aI_DBDataSet);
            }

        }

        private void gridControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Up || e.KeyChar == (char)Keys.Down
               || e.KeyChar == (char)Keys.PageUp || e.KeyChar == (char)Keys.PageDown)
            {
                this.Validate();
                this.employee_tblTableAdapter.Update(this.aI_DBDataSet);
            }
            if (e.KeyChar == (char)Keys.Insert)
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Append);
            }
            if (e.KeyChar.ToString() == Keys.Delete.ToString())
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Remove);
                this.Validate();
                this.employee_tblTableAdapter.Update(this.aI_DBDataSet);
            }

        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down
              || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown)
            {
                this.Validate();
                this.employee_tblTableAdapter.Update(this.aI_DBDataSet);
            }
            if (e.KeyCode == Keys.Insert)
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Append);
            }
            if (e.KeyCode.ToString() == Keys.Delete.ToString())
            {
                this.controlNavigator1.NavigatableControl.DoAction(NavigatorButtonType.Remove);
                this.Validate();
                this.employee_tblTableAdapter.Update(this.aI_DBDataSet);
            }

        }

        private void controlNavigator2_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType.ToString() != "Append")
            {
                this.Validate();
                this.video_List_tblTableAdapter.Update(this.aI_DBDataSet);


            }
        }

        private void gridControl2_EditorKeyDown(object sender, KeyEventArgs e)
        {
        }

        private void gridControl2_EditorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Up || e.KeyChar == (char)Keys.Down
              || e.KeyChar == (char)Keys.PageUp || e.KeyChar == (char)Keys.PageDown)
            {
                this.Validate();
                this.video_List_tblTableAdapter.Update(this.aI_DBDataSet);
            }
            if (e.KeyChar == (char)Keys.Insert)
            {
                this.controlNavigator2.NavigatableControl.DoAction(NavigatorButtonType.Append);
            }
            if (e.KeyChar.ToString() == Keys.Delete.ToString())
            {
                this.controlNavigator2.NavigatableControl.DoAction(NavigatorButtonType.Remove);
                this.Validate();
                this.video_List_tblTableAdapter.Update(this.aI_DBDataSet);
            }
        }

        private void gridControl2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Up || e.KeyChar == (char)Keys.Down
               || e.KeyChar == (char)Keys.PageUp || e.KeyChar == (char)Keys.PageDown)
            {
                this.Validate();
                this.video_List_tblTableAdapter.Update(this.aI_DBDataSet);
            }
            if (e.KeyChar == (char)Keys.Insert)
            {
                this.controlNavigator2.NavigatableControl.DoAction(NavigatorButtonType.Append);
            }
            if (e.KeyChar.ToString() == Keys.Delete.ToString())
            {
                this.controlNavigator2.NavigatableControl.DoAction(NavigatorButtonType.Remove);
                this.Validate();
                this.video_List_tblTableAdapter.Update(this.aI_DBDataSet);
            }
        }

        private void gridControl2_ProcessGridKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down
              || e.KeyCode == Keys.PageUp || e.KeyCode == Keys.PageDown)
            {
                this.Validate();
                this.video_List_tblTableAdapter.Update(this.aI_DBDataSet);
            }
            if (e.KeyCode == Keys.Insert)
            {
                this.controlNavigator2.NavigatableControl.DoAction(NavigatorButtonType.Append);
            }
            if (e.KeyCode.ToString() == Keys.Delete.ToString())
            {
                this.controlNavigator2.NavigatableControl.DoAction(NavigatorButtonType.Remove);
                this.Validate();
                this.video_List_tblTableAdapter.Update(this.aI_DBDataSet);
            }

        }
    }
}