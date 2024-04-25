﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueReef.Common
{
    public static class WebUtilities
    {
        public static readonly int ADMIN_ROLE = 1;
        public static readonly int USER_ROLE = 2;
        public static readonly string CURRENT_USER = "CurrentUser";

        public static void Set<T>(this ISession session,string Key,T value)
        {
            string jsonData = JsonConvert.SerializeObject(value);
            session.SetString(Key, jsonData);
        }

        public static object Get<T>(this ISession session, string Key)
        {
            string jsonData = session.GetString(Key);
            if (string.IsNullOrEmpty(jsonData)) return default;
            return JsonConvert.DeserializeObject<T>(jsonData);
           
        }



    }

    
}
