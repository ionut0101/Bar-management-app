using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using UserDetails;

namespace UserDB
{
    public class UserDB
    {
        readonly private string dataBaseName;
        readonly private char dataBaseSeparator = ':';
        readonly private Dictionary<string, int> dataBaseColumns = new Dictionary<string, int>();

        public UserDB(string databaseName = "users.txt")
        {
            dataBaseName = AppDomain.CurrentDomain.BaseDirectory + databaseName;

            if (!File.Exists(dataBaseName))
            {
                File.Create(dataBaseName).Close();
            }

            dataBaseColumns.Add( "Id", 0 );
            dataBaseColumns.Add( "Name", 1 );
            dataBaseColumns.Add( "Role", 2 );
            dataBaseColumns.Add( "Password", 3 );
        }

        public string ToStringFormat(IUser user)
        {            
            string result = string.Empty;
            foreach (string tableKey in dataBaseColumns.Keys)
            {
                result += user.GetValue(tableKey) + dataBaseSeparator;
            }

            result = result.Remove(result.Length - 1, 1);

            return result;
        }

        public IUser ToUserFormat(string payload)
        {
            IUser user = new User();
            string[] details = payload.Split(dataBaseSeparator);

            int index;
            string tableColumn;

            try
            {
                for (index = 0; index < details.Length; index++)
                {
                    tableColumn = dataBaseColumns.FirstOrDefault(x => x.Value == index).Key;
                    if (tableColumn != null)
                    {
                        user.UpdateValue(tableColumn, details[index]);
                    }
                }

                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public string GetLastInsertedId()
        {
            string lastId = "0";
            string lastRow = string.Empty, currentRow;
            StreamReader streamReader = new StreamReader(dataBaseName);

            while ((currentRow = streamReader.ReadLine()) != null)
            {
                lastRow = currentRow;
            }

            streamReader.Close();

            if (lastRow != string.Empty)
            {
                IUser user = ToUserFormat(lastRow);
                return user.GetValue( "Id" );
            }

            return lastId;
        }

        public List<IUser> GetAll()
        {
            List<IUser> users = new List<IUser>();

            IUser currentUser;
            StreamReader streamReader = new StreamReader(dataBaseName);
            string databaseRow;

            while ((databaseRow = streamReader.ReadLine()) != null)
            {
                currentUser = ToUserFormat(databaseRow);
                users.Add(currentUser);
            }

            streamReader.Close();
            return users;
        }

        public bool Create(IUser user)
        {
            try
            {
                string lastId = GetLastInsertedId();
                int nextId = Convert.ToInt32(lastId);
                nextId++;

                user.UpdateValue("Id", nextId.ToString());

                StreamWriter streamWriter = new StreamWriter(dataBaseName, append: true);
                string streamPayload = ToStringFormat(user);

                streamWriter.WriteLine(streamPayload);
                streamWriter.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IUser LookupByName( string userName )
        {
            string dataBaseRow;
            IUser user;
            IUser userRow = null;
            userName = userName.ToLower();

            if ( userName.Length == 0 )
            {
                return null;
            }

            try
            {
                StreamReader streamReader = new StreamReader(dataBaseName);

                while ((dataBaseRow = streamReader.ReadLine()) != null)
                {
                    user = ToUserFormat(dataBaseRow);
                    if ( user.GetValue( "Name" ).ToLower() == userName )
                    {
                        /* 
                        * nu stiu sigur ce se intampla daca fac return direct 
                         * ( poate nu mai functioneaza logica IO close file -> no idea ) 
                         * nu am timp sa caut pe google nici sa testez e facut totul fast-forward
                        */
                        userRow = user;
                    }
                }

                streamReader.Close();

                return userRow;
            } 
            catch( Exception ) { }
            return null;
        }

        public string ToMD5(string password)
        {
            /*
             * folosesc md5 pentru hash-uirea parolei (testing-purposes) , metoda proasta , real-world -> bcrypt & salt / AES
             */
            using (var md5Hash = MD5.Create())
            {
                var sourceBytes = Encoding.UTF8.GetBytes(password);
                var hashBytes = md5Hash.ComputeHash(sourceBytes);
                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                return hash;
            }
        }

        public int Count()
        {
            int userCount = 0;

            StreamReader streamReader = new StreamReader(dataBaseName);
            string databaseRow;

            while ((databaseRow = streamReader.ReadLine()) != null)
            {
                userCount++;
            }

            streamReader.Close();

            return userCount;
        }

        public bool Register( IUser user )
        {
            // Input validations are handled by the UserIntegrityCheck library

            // The user is already registered
            if ( LookupByName( user.Name ) != null )
            {
                return false;
            }

            // Assign root privileges to the initial account upon creation
            if( Count() == 0 )
            {
                user.UpdateValue( "Role", Roles.Admin.ToString() );
            } else
            {
                // initial register as viewer
                user.UpdateValue( "Role", Roles.Viewer.ToString() );
                // The root account has the ability to update roles for other users
            }

            try
            {
                string lastId = GetLastInsertedId();
                int nextId = Convert.ToInt32( lastId );
                nextId++;

                string hashedPassword = ToMD5( user.GetValue( "Password" ) );

                user.UpdateValue( "Id" , nextId.ToString() );
                user.UpdateValue( "Password" , hashedPassword );

                StreamWriter streamWriter = new StreamWriter(dataBaseName, append: true);
                string streamPayload = ToStringFormat(user);

                streamWriter.WriteLine(streamPayload);
                streamWriter.Close();

                return true;
            }
            catch (Exception) { }

            return false;
        }

        public IUser Auth( string userName , string password )
        {
            // No sessions like a real-world scenario

            if ( userName.Length == 0 || password.Length == 0 )
            {
                return null;
            }

            IUser account = LookupByName( userName );
            if( account != null )
            {
                string passwordHash = ToMD5( password );
                if( account.GetValue( "Password" ) == passwordHash )
                {
                    return account;
                }
            }
            
            return null;
        }

        // DeleteById & Update to be implemented
    }
}
