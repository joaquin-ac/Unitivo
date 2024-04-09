namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class ManejoBD : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Unitivo;Integrated Security=True";
        private string databaseName = "Unitivo";
        private string backupFilePath = @"C:\BackUpUnitivo\Backup.bak";
        public ManejoBD()
        {
            InitializeComponent();
        }

        private void BResguardar_Click(object sender, EventArgs e)
        {
            DatabaseBackupRestore backupRestore = new DatabaseBackupRestore(connectionString);
            backupRestore.BackupDatabase(databaseName, backupFilePath);
        }

        private void BRestaurar_Click(object sender, EventArgs e)
        {     
            DatabaseBackupRestore backupRestore = new DatabaseBackupRestore(connectionString);
            backupRestore.RestoreDatabase(databaseName, backupFilePath);
        }
    }
}
