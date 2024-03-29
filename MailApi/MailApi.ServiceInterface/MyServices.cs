﻿using MailApi.ServiceModel;
using ServiceStack;

namespace MailApi.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse {Result = "Hello, {0}!".Fmt(request.Name)};
        }
    }
}