using Studentska.Data.Modeli.IspitIB230XXX;
using Studentska.Servis.Servisi.IspitIB230XXX;
using Studentska.WinApp.Helpers;

namespace Studentska.WinApp.IspitIB230XXX;

public partial class frmKnjigaAddEditIB230XXX : Form
{
    private int _knjigaId = 0;
    private bool _isEdit => _knjigaId != 0;

    public frmKnjigaAddEditIB230XXX()
    {
        InitializeComponent();
    }

    public frmKnjigaAddEditIB230XXX(int knjigaId)
    {
        InitializeComponent();

        _knjigaId = knjigaId;
        LoadKnjigaData();
    }

    private void LoadKnjigaData()
    {
        using var knjigeServis = new KnjigeServisIB230XXX();
        var knjiga = knjigeServis.GetById(_knjigaId);

        if (knjiga is null)
        {
            System.Diagnostics.Debug.WriteLine($"Knjiga za id {_knjigaId} ne postoji");
            return;
        }

        txtNaziv.Text = knjiga.Naziv;
        txtAutori.Text = knjiga.Autor;
        txtBrojPrimjeraka.Text = knjiga.BrojPrimjeraka.ToString();
        pbSlika.Image = ImageHelper.ByteToImage(knjiga.Slika);
    }

    private bool ValidateFields()
    {
        using var knjigeServis = new KnjigeServisIB230XXX();

        string nazivKnjige = txtNaziv.Text.Trim();
        string nazivAutora = txtAutori.Text.Trim();

        if (nazivKnjige.Length == 0)
        {
            MessageBox.Show(
                "Naziv knjige je obavezno polje",
                "Nevalidan unos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }
        else if (nazivAutora.Length == 0)
        {
            MessageBox.Show(
                "Autori knjige je obavezno polje",
                "Nevalidan unos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }
        else if (!_isEdit && knjigeServis.DoesKnjigaExist(nazivKnjige, nazivAutora))
        {
            MessageBox.Show(
                "Naziv knjige i autora vec postoji",
                "Nevalidan unos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }
        else if (pbSlika.Image is null)
        {
            MessageBox.Show(
                "Slika knjige je obavezno polje",
                "Nevalidan unos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }
        else if (!int.TryParse(txtBrojPrimjeraka.Text, out int brojPrimjeraka) || brojPrimjeraka < 1)
        {
            MessageBox.Show(
                "Broj primjeraka mora biti broj veci ili jednak 1",
                "Nevalidan unos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }

        return true;
    }

    private KnjigeIB230XXX GetKnjiga()
    {
        var knjiga = new KnjigeIB230XXX
        {
            Naziv = txtNaziv.Text.Trim(),
            Autor = txtAutori.Text.Trim(),
            BrojPrimjeraka = int.Parse(txtBrojPrimjeraka.Text),
            Slika = ImageHelper.ImageToByte(pbSlika.Image)
        };

        return knjiga;
    }

    private void btnSacuvaj_Click(object sender, EventArgs e)
    {
        if (!ValidateFields())
        {
            return;
        }

        using var knjigeServis = new KnjigeServisIB230XXX();

        var knjiga = GetKnjiga();
        
        if (_isEdit)
        {
            knjigeServis.Edit(_knjigaId, knjiga);
        }
        else
        {
            knjigeServis.Add(knjiga);
        }

        Close();
    }

    private void pbSlika_DoubleClick(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog();

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            pbSlika.Image = Image.FromFile(openFileDialog.FileName);
        }
    }
}
