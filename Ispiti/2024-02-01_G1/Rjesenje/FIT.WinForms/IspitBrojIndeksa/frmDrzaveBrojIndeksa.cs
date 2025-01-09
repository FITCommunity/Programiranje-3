using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmDrzaveBrojIndeksa : Form
    {
        private readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;

        public frmDrzaveBrojIndeksa()
        {
            InitializeComponent();

            SetCurrentTimeLbl();
            SetDgvProperties();
            LoadDrzaveIntoDgv();
        }

        private void SetCurrentTimeLbl()
            => lblCurrentTime.Text = $"Trenutno vrijeme: {DateTime.Now:HH:mm:ss}";

        private void SetDgvProperties()
        {
            dgvDrzave.ReadOnly = true;
            dgvDrzave.MultiSelect = false;
            dgvDrzave.AutoGenerateColumns = false;
            dgvDrzave.AllowUserToResizeColumns = false;
            dgvDrzave.AllowUserToResizeRows = false;
            dgvDrzave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadDrzaveIntoDgv()
        {
            dgvDrzave.DataSource = null;
            dgvDrzave.DataSource = _DLWMSDbContext.Drzave
                                                  .Include(drzava => drzava.Gradovi)
                                                  .ToList();
        }

        private void CurrentTimeTmrTick(object? sender, EventArgs e)
            => SetCurrentTimeLbl();

        private void OpenNovaDrzavaForm(DrzaveBrojIndeksa? drzava = null)
        {
            using frmNovaDrzavaBrojIndeksa frmNovaDrzavaBrojIndeksa = new(drzava);
            frmNovaDrzavaBrojIndeksa.ShowDialog();
            LoadDrzaveIntoDgv();
        }

        private void NovaDrzavaBtnClick(object? sender, EventArgs e)
            => OpenNovaDrzavaForm();

        private void PrintajBtnClick(object? sender, EventArgs e)
        {
            if (dgvDrzave.SelectedRows.Count == 0)
            {
                return;
            }

            var drzava = (DrzaveBrojIndeksa)dgvDrzave.SelectedRows[0].DataBoundItem;

            using frmGradoviReportBrojIndeksa frmGradoviReportBrojIndeksa = new(drzava);
            frmGradoviReportBrojIndeksa.ShowDialog();
        }

        private void DrzaveDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isGradoviClick = e.ColumnIndex == DrzavaGradoviBtn.Index;

            if (e.RowIndex < 0 || !isGradoviClick)
            {
                return;
            }

            var drzava = (DrzaveBrojIndeksa)dgvDrzave.Rows[e.RowIndex].DataBoundItem;

            using frmGradoviBrojIndeksa frmGradoviBrojIndeksa = new(drzava);
            frmGradoviBrojIndeksa.ShowDialog();

            LoadDrzaveIntoDgv();
        }

        private void DrzaveDgvCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var drzava = (DrzaveBrojIndeksa)dgvDrzave.Rows[e.RowIndex].DataBoundItem;

            OpenNovaDrzavaForm(drzava);
        }
    }
}
