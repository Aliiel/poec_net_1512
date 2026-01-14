
using Exercices.Classes;
using MySql.Data.MySqlClient;

string connectionString = "Server=localhost;Database=exercice_ADO;User ID=root;Password=root";

void AjouterEtudiant()
{
    Console.WriteLine("--- Ajouter un étudiant ---");
    Console.WriteLine("Nom : ");
    var nom = Console.ReadLine();

    Console.WriteLine("Prénom : ");
    var prenom = Console.ReadLine();

    Console.WriteLine("Numéro de classe : ");
    var numeroClasse = Console.ReadLine();

    Console.WriteLine("Date d'obtention du diplôme : ");
    var dateDiplome = Console.ReadLine();

    try
    {
        DateTime dateConvertie = DateTime.Parse(dateDiplome);

        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();

            string query = "INSERT INTO Etudiants (nom, prenom, numero_classe, date_diplome) VALUES (@nom, @prenom, @numero_classe, @date_diplome)";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@prenom", prenom);
            cmd.Parameters.AddWithValue("@numero_classe", numeroClasse);
            cmd.Parameters.AddWithValue("@date_diplome", dateConvertie);

            int rowAffected = cmd.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                Console.WriteLine("Etudiant ajouté avec succès ! ");
            }

        }
        catch (MySqlException ex)
        {
            Console.WriteLine($"Erreur : {ex.Message}");
        }
        finally
        {
            connection.Close();
        }

    } catch (Exception ex) 
    {
        Console.WriteLine("Erreur dans la conversion de la date");
    }
}


void AfficherTousLesEtudiants()
{
    Console.WriteLine("--- Liste des étudiants ---");
    MySqlConnection connexion = new MySqlConnection(connectionString);

    try
    {
        connexion.Open();

        string query = "SELECT * FROM Etudiants";
        MySqlCommand cmd = new MySqlCommand(query, connexion);

        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Etudiants etudiant = new Etudiants(
                    reader.GetInt32("id"),
                    reader.GetString("nom"),
                    reader.GetString("prenom"),
                    reader.GetString("numero_classe"),
                    reader.GetDateTime("date_diplome")
                    );

                Console.WriteLine(etudiant);
            }
        }
        else
        {
            Console.WriteLine("Aucun étudiant encore enregistré dans la bdd");
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


void AfficherEtudiantsParClasse()
{
    Console.WriteLine("--- Recherche par classe ---");
    Console.WriteLine("Classe à afficher : ");
    var numeroClasse = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);

    try
    {
        connection.Open();

        string query = "SELECT * FROM Etudiants WHERE numero_classe = @numero_classe";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@numero_classe", numeroClasse);

        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            Console.WriteLine($"--- Liste des étudiants de la classe numéro {numeroClasse} ---");

            while (reader.Read())
            {
                Etudiants etudiant = new Etudiants(
                    reader.GetInt32("id"),
                    reader.GetString("nom"),
                    reader.GetString("prenom"),
                    reader.GetString("numero_classe"),
                    reader.GetDateTime("date_diplome")
                    );

                Console.WriteLine(etudiant);
            }
        }
        else
        {
            Console.WriteLine("Aucun étudiant dans la classe saisie");
        }

        reader.Close();

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


void RechercherEtudiantParId()
{
    Console.WriteLine("--- Recherche par id ---");
    Console.WriteLine("Id de l'étudiant à rechercher : ");
    var id = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);

    try
    {
        connection.Open();

        string query = "SELECT * FROM Etudiants WHERE id = @id";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", id);

        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            Etudiants etudiant = new Etudiants(
                    reader.GetInt32("id"),
                    reader.GetString("nom"),
                    reader.GetString("prenom"),
                    reader.GetString("numero_classe"),
                    reader.GetDateTime("date_diplome")
                    );

            Console.WriteLine($"Etudiant trouvé : {etudiant}");

        }
        else
        {
            Console.WriteLine("Aucun étudiant trouvé avec cet ID");
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


void RechercherEtudiantParNom() {

    Console.WriteLine("--- Recherche par nom ---");
    Console.WriteLine("Nom de l'étudiant à rechercher : ");
    var nom = Console.ReadLine();

    MySqlConnection connection = new MySqlConnection(connectionString);

    try
    {
        connection.Open();

        string query = "SELECT * FROM Etudiants WHERE nom LIKE @nom";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@nom", nom);

        MySqlDataReader reader = cmd.ExecuteReader();

        if (reader.Read())
        {
            Etudiants etudiant = new Etudiants(
                    reader.GetInt32("id"),
                    reader.GetString("nom"),
                    reader.GetString("prenom"),
                    reader.GetString("numero_classe"),
                    reader.GetDateTime("date_diplome")
                    );

            Console.WriteLine($"Etudiant trouvé : {etudiant} ");

        }
        else
        {
            Console.WriteLine("Aucun étudiant trouvé avec ce nom");
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


void ModifierEtudiant ()
{
    Console.WriteLine("--- Modifier un étudiant ---");
    Console.WriteLine("Id de l'étudiant à modifier : ");
    var id = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);

    try
    {
        connection.Open();

        string queryCheck = "SELECT COUNT(*) FROM Etudiants WHERE id = @id";
        MySqlCommand cmdCheck = new MySqlCommand(queryCheck, connection);
        cmdCheck.Parameters.AddWithValue("@id", id);

        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

        if (count == 0)
        {
            Console.WriteLine("Aucun étudiant trouvé avec cet id");
            return;
        }

        Console.WriteLine("Nouveau nom : ");
        var nom = Console.ReadLine();
        Console.WriteLine("Nouveau prénom : ");
        var prenom = Console.ReadLine();
        Console.WriteLine("Nouveau numéro de classe : ");
        var numeroClasse = Console.ReadLine();
        Console.WriteLine("Nouvelle date de diplôme : ");
        var dateDiplome = Console.ReadLine();

        DateTime dateConvertie = DateTime.Parse(dateDiplome);

        string query = "UPDATE Etudiants SET nom = @nom, prenom = @prenom, numero_classe = @numero_classe, date_diplome = @date_diplome WHERE id = @id";

        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@nom", nom);
        cmd.Parameters.AddWithValue("@prenom", prenom);
        cmd.Parameters.AddWithValue("@numero_classe", numeroClasse);
        cmd.Parameters.AddWithValue("@date_diplome", dateConvertie);

        int rowsAffected = cmd.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
            Console.WriteLine("L'étudiant a bien été modifié");
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


void SupprimerEtudiant()
{
    Console.WriteLine("--- Supprimer un étudiant ---");
    Console.WriteLine("Id de l'étudiant à supprimer : ");

    int id = int.Parse(Console.ReadLine());

    MySqlConnection connection = new MySqlConnection(connectionString);

    try
    {
        connection.Open();

        string query = "DELETE FROM Etudiants WHERE id = @id";
        MySqlCommand cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", id);

        int rowsAffected = cmd.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
            Console.WriteLine("L'étudiant a bien été supprimé");
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


void AfficherMenu()
{
    Console.WriteLine("Bienvenue dans la gestion des étudiants !" +
        "\n Que souhaitez-vous faire ? " +
        "\n1 - Ajouter un nouvel étudiant" +
        "\n2 - Afficher tous les étudiants" +
        "\n3 - Afficher les étudiants d'une classe" +
        "\n4 - Rechercher un étudiant par id" +
        "\n5 - Afficher les étudiants par nom" +
        "\n6 - Modifier un étudiant" +
        "\n7 - Supprimer un étudiant" +
        "\n8 - Quitter le programme");


    string choix;

    do
    {
        Console.Write("Votre choix : ");
        choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                AjouterEtudiant();
                break;
            case "2":
                AfficherTousLesEtudiants();
                break;
            case "3":
                AfficherEtudiantsParClasse();
                break;
            case "4":
                RechercherEtudiantParId();
                break;
            case "5":
                RechercherEtudiantParNom();
                break;
            case "6":
                ModifierEtudiant();
                break;
            case "7":
                SupprimerEtudiant();
                break;
            default:
                Console.WriteLine("Veuillez saisir un choix parmi ceux proposés");
                break;
        }
    } while (choix != "8");
}



AfficherMenu();






