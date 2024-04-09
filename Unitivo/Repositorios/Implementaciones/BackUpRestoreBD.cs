using System.Data.SqlClient;
using System;
using System.Diagnostics;

public class DatabaseBackupRestore
{
    private readonly string connectionString;

    public DatabaseBackupRestore(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void BackupDatabase(string databaseName, string backupFilePath)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string backupQuery = $"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}'";
                SqlCommand command = new SqlCommand(backupQuery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show($"Backup de la base de datos '{databaseName}' realizado con éxito en '{backupFilePath}'.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al realizar el backup de la base de datos '{databaseName}': {ex.Message}");
        }
    }

    public void RestoreDatabase(string databaseName, string backupFilePath)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string restoreQuery = $"USE master; RESTORE DATABASE [{databaseName}] FROM DISK = '{backupFilePath}'";
                SqlCommand command = new SqlCommand(restoreQuery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show($"Restauración de la base de datos '{databaseName}' realizada con éxito desde '{backupFilePath}'.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al restaurar la base de datos '{databaseName}': {ex.Message}");
        }
    }
}