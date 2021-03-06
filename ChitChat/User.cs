﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ChitChat
{
    public class User
    {
        public int id_ { get; private set; }
        public string name_ { get; private set; }
        public string username_ { get; private set; }
        public string pass_ { get; private set; }
        public int age_ { get; private set; }
        public bool male_ { get; private set; }
        public string note_ { get; private set; }
        public IPAddress ip_ { get; private set; }
        public Dictionary<int,string> contacts_ { get; private set; }

        public User(int id, string name, string username, string pass, int? age, bool? male, string note, string ip)
        {
            id_ = id;
            name_ = name;
            username_ = username;
            pass_ = pass;
            if (age.HasValue) age_ = age.Value;
            else age_ = 0;
            if (male.HasValue) male_ = male.Value;
            note_ = note;
            ip_ = ip == null ? null : IPAddress.Parse(ip);
        }
        public User(string name, string username, string pass, int? age, bool? male, string note, string ip)
        {
            name_ = name;
            username_ = username;
            pass_ = pass;
            if (age.HasValue) age_ = age.Value;
            else age_ = 0;
            if (male.HasValue) male_ = male.Value;
            note_ = note;
            ip_ = ip == null ? null : IPAddress.Parse(ip);

        }
        public User(string username)
        {
            username_ = username;
        }
        public static async Task<User> load_UserAsync(User user)
        {
            try
            {
                using (var database = new Database())
                {
                    await database.openDatabaseAsync();
                    user = await database.selectUserByUsernameAsync(user);
                    user.contacts_ = await database.selectContactsAsync(user.id_);
                }
                return user;
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        public async Task updateUserIPAsync(string newIp)
        {

            this.ip_ = IPAddress.Parse(newIp);
            using (var database = new Database())
            {
                await database.openDatabaseAsync();
                database.updateIPAsync(this.username_, newIp);
            }
        }
        
    }
}
