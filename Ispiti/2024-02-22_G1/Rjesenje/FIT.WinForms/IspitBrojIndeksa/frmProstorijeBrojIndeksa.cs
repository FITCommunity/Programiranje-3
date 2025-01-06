using FIT.Data.IspitBrojIndeksa;
using FIT.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IspitBrojIndeksa
{
    public partial class frmProstorijeBrojIndeksa : Form
    {
        private static readonly DLWMSDbContext _DLWMSDbContext = SharedBrojIndeksa.DLWMSDbContext;

        public frmProstorijeBrojIndeksa()
        {
            InitializeComponent();

            SetDgvStyleProperties();
            LoadProstorijeIntoDgv();
        }

        private void SetDgvStyleProperties()
        {
            dgvProstorije.ReadOnly = true;
            dgvProstorije.MultiSelect = false;
            dgvProstorije.AutoGenerateColumns = false;
            dgvProstorije.AllowUserToResizeColumns = false;
            dgvProstorije.AllowUserToResizeRows = false;
            dgvProstorije.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadProstorijeIntoDgv()
        {
            dgvProstorije.DataSource = null;
            dgvProstorije.DataSource = _DLWMSDbContext.Prostorije
                                                      .Include(prostorija => prostorija.Predmeti)
                                                      .ToList();
        }

        private void OpenNovaProstorijaForm(ProstorijeBrojIndeksa? prostorija = null)
        {
            using frmNovaProstorijaBrojIndeksa frmNovaProstorijaBrojIndeksa = new(prostorija);

            frmNovaProstorijaBrojIndeksa.ShowDialog();

            LoadProstorijeIntoDgv();
        }

        private void NovaProstorijaBtnClick(object? sender, EventArgs e)
            => OpenNovaProstorijaForm();

        private void PrintajBtnClick(object? sender, EventArgs e)
        {
            if (dgvProstorije.SelectedRows.Count == 0)
            {
                return;
            }

            var prostorija = (ProstorijeBrojIndeksa)dgvProstorije.SelectedRows[0].DataBoundItem;

            using frmEvidencijaNastaveBrojIndeksa frmEvidencijaNastaveBrojIndeksa = new(prostorija);
            frmEvidencijaNastaveBrojIndeksa.ShowDialog();
        }

        private void ProstorijeDgvCellClick(object? sender, DataGridViewCellEventArgs e)
        {
            bool isNastavaClick = e.ColumnIndex == ProstorijaNastavaBtn.Index;
            bool isPrisustvoClick = e.ColumnIndex == ProstorijaPrisustvoBtn.Index;

            if (e.RowIndex < 0 || (!isNastavaClick && !isPrisustvoClick))
            {
                return;
            }

            var prostorija = (ProstorijeBrojIndeksa)dgvProstorije.Rows[e.RowIndex].DataBoundItem;

            if (isNastavaClick)
            {
                using frmNastavaBrojIndeksa frmNastavaBrojIndeksa = new(prostorija);
                frmNastavaBrojIndeksa.ShowDialog();
                LoadProstorijeIntoDgv();
                return;
            }

            using frmPrisustvoBrojIndeksa frmPrisustvoBrojIndeksa = new(prostorija);
            frmPrisustvoBrojIndeksa.ShowDialog();
        }

        private void ProstorijeDgvCellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var prostorija = (ProstorijeBrojIndeksa)dgvProstorije.Rows[e.RowIndex].DataBoundItem;

            OpenNovaProstorijaForm(prostorija);
        }
    }
}
