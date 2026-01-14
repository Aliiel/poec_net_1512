

using Demo.Classes;
using MySql.Data.MySqlClient;


string connectionString = "Server=localhost;Database=demo_ado;User ID=root;Password=root";

void AjouterPersonne()
{
    Console.WriteLine("--- Ajouter une personne ---");
    Console.WriteLine("Nom : ");
    var nom = Console.ReadLine();

    Console.WriteLine("Prénom : ");
    var prenom = Console.ReadLine();

    Console.WriteLine("Age : ");
    var age = Console.ReadLine();

    Console.WriteLine("Email : ");
    var email = Console.ReadLine();

    MySqlConnection connection = new MySqlConnection(connectionString);

    try
    {
        connection.Open();

        string query = "INSERT INTO Personne (nom, prenom, age, email) VALUES (@nom, @prenom, @age, @email)";
        MySqlCommand cmd = new MySqlCommand(query, connection);

        cmd.Parameters.AddWithValue("@nom", nom);
        cmd.Parameters.AddWithValue("@prenom", prenom);
        cmd.Parameters.AddWithValue("@age", age);
        cmd.Parameters.AddWithValue("@email", email);

        int rowAffected = cmd.ExecuteNonQuery();
        if (rowAffected > 0)
        {
            Console.WriteLine("Personne ajoutée avec succès ! ");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
    finally 
    {
        connection.Close();
    }
}


// Méthode READ
void AfficherToutesLesPersonnes ()
{
    Console.WriteLine("--- Liste des personnes ---");
    MySqlConnection connexion = new MySqlConnection(connectionString);

    try
    {
        connexion.Open();

        string query = "SELECT * FROM Personne";
        MySqlCommand cmd = new MySqlCommand(query, connexion);

        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Personne p = new Personne(
                    reader.GetInt32("id"),
                    reader.GetString("nom"),
                    reader.GetString("prenom"),
                    reader.GetInt32("age"),
                    reader.GetString("email")
                    );

                Console.WriteLine(p);
            }
        }
        else
        {
            Console.WriteLine("Aucune personne encore enregistrée dans la bdd");
        }

        reader.Close();

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connexion.Close();
    }
}


void RechercherPersonneParId ()
{
    Console.WriteLine("--- Recherche par Id ---");
    Console.WriteLine("Id de la personne recherchée : ");
    var id = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);

    try
    {
        connection.Open();

        string query = "SELECT * FROM Personne WHERE id = @id";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", id);

        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            Personne p = new Personne(
                    reader.GetInt32("id"),
                    reader.GetString("nom"),
                    reader.GetString("prenom"),
                    reader.GetInt32("age"),
                    reader.GetString("email")
                    );

            Console.WriteLine($"Personne trouvée : {p}");

        }
        else
        {
            Console.WriteLine("Aucune personne trouvée avec cet ID");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
    }
}


void UpdatePersonne ()
{
    Console.WriteLine("--- Modifier une personne ---");
    Console.WriteLine("Id de la personne à modifier : ");
    var id = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);

    try
    {
        connection.Open();

        string queryCheck = "SELECT COUNT(*) FROM Personne WHERE id = @id";
        MySqlCommand cmdCheck = new MySqlCommand( queryCheck, connection);
        cmdCheck.Parameters.AddWithValue("@id", id);

        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

        if (count == 0)
        {
            Console.WriteLine("Aucune personne trouvée avec cet id");
            return;
        }

        Console.WriteLine("Nouveau nom : ");
        var nom = Console.ReadLine();
        Console.WriteLine("Nouveau prénom : ");
        var prenom = Console.ReadLine();
        Console.WriteLine("Nouvel âge : ");
        var age = Console.ReadLine();
        Console.WriteLine("Nouvel email : ");
        var email = Console.ReadLine();

        string query = "UPDATE Personne SET nom = @nom, prenom = @prenom, age = @age, email = @email WHERE id = @id";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@nom", nom);
        cmd.Parameters.AddWithValue("@prenom", prenom);
        cmd.Parameters.AddWithValue("@age", age);
        cmd.Parameters.AddWithValue("@email", email);

        int rowsAffected = cmd.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
            Console.WriteLine("Personne modifée avec succès");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close();
    }
}


void DeletePersonne ()
{
    Console.WriteLine("--- Supprimer une personne ---");
    Console.WriteLine("Id de la personne à supprimer : ");

    int id = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);

    try
    {
        connection.Open();

        string query = "DELETE FROM Personne WHERE id = @id";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", id);
        
        int rowsAffected = cmd.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
            Console.WriteLine("Personne supprimée avec succès");
        }

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        connection.Close(); 
    }
}

AjouterPersonne();
AfficherToutesLesPersonnes();
RechercherPersonneParId();
UpdatePersonne();
DeletePersonne();
