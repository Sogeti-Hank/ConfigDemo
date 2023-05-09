
        static void Main(string[] args)
        {
            var config = new ParentConfig();
            config.TenantID = "123";
            config.UserName = "test";
            config.ParentConfigID = "<SomeGuid.SomeVersion>";

            //Add a subscriber config
            config.SubscriberConfig = new SubscriberConfig();
            config.SubscriberConfig.URI = "http://www.google.com";

            //Add a child config
            config.ChildConfig01 = new ChildConfig01();
            config.ChildConfig01.SerializedEquasion = "1+1";
            config.ChildConfig01.SomeOtherThingWeHaveNotDefinedYetBecauseItIsntNeededToday = "test";

            //Serialize the config
            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            Console.WriteLine(json);

            //Save the config
            SomeFakeServiceGRPCThingy service = new SomeFakeServiceGRPCThingy();
            service.SaveConfig(config);      
            

        }