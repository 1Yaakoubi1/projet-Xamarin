using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace App1Xamarin.ModelProjet
{
    public class UserDatabase
    {
        SQLiteAsyncConnection connection;

        //generer la table
        public UserDatabase(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<User>().Wait();

        }


        // retourner la liste des utilisateurs
        public Task<List<User>> GetUSERSAsync()
        {
            return connection.Table<User>().ToListAsync();

        }

        // retourner un utilisateur de la table
        public Task<User> GetUserAsync(int id)
        {
            return connection.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();

        }

        //retourner un utilisateur de la table (nom, password)

        public Task<User> FindUser(string name, string password)
        {
            return connection.Table<User>().Where(i => i.nom.Equals(name) && i.mdp.Equals(password)).FirstOrDefaultAsync();

        }

        //retourner un utilisateur de la table (nom, password)

        public Task<User> FindUserLogin(string name)
        {
            return connection.Table<User>().Where(i => i.nom.Equals(name)).FirstOrDefaultAsync();

        }

        //enregistrer un utilisateur 

        public Task<int> SaveUserAsync(User user)

        {
            if (user.ID != 0)
            {
                return connection.UpdateAsync(user);
            }
            else
            {
                return connection.InsertAsync(user);
            }
        }


        //Supprimer un contact

        public Task<int> DeleteUserAsync(User user)

        {
            return connection.DeleteAsync(user);


        }


    }
}





