[Flags]
        enum ServiceRequirements
        {
            None = 0,
            WheelAlignment = 1,
            Dirty = 2,
            EngineTune = 4,
            TestDrive = 8
        }

        class Car
        {
            public ServiceRequirements Requirements { get; set; }
            public bool IsServiceComplete
            {
                get
                {
                    return Requirements == ServiceRequirements.None;
                }
            }
        }

        abstract class ServiceHandler
        {
            protected ServiceHandler _nextServiceHandler;
            protected ServiceRequirements _servicesProvided;
            public ServiceHandler(ServiceRequirements servicesProvided)
            {
                _servicesProvided = servicesProvided;
            }
        }

        //and chain

        class Detailer : ServiceHandler
        {
            public Detailer() : base(ServiceRequirements.Dirty) { }
        }

        class Mechanic : ServiceHandler
        {
            public Mechanic() : base(ServiceRequirements.EngineTune) { }
        }

        class WheelSpecialist : ServiceHandler
        {
            public WheelSpecialist() : base(ServiceRequirements.WheelAlignment) { }
        }

        class QualityControl : ServiceHandler
        {
            public QualityControl() : base(ServiceRequirements.TestDrive) { }
        }

        //and finally

        var mechanic = new Mechanic();
        var detailer = new Detailer();
        var wheels = new WheelSpecialist();
        var qa = new QualityControl();

        qa.SetNextServiceHandler(detailer);
        wheels.SetNextServiceHandler(qa);
        mechanic.SetNextServiceHandler(wheels);




