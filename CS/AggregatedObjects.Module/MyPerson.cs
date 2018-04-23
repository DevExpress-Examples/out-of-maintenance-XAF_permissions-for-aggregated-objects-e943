using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace AggregatedObjects.Module {
    [DefaultClassOptions]
    public class MyPerson : BaseObject {
        public MyPerson(Session session) : base(session) { }

        public string Name {
            get { return GetPropertyValue<string>("Name"); }
            set { SetPropertyValue<string>("Name", value); }
        }

        [Association("Person-Addresses"), Aggregated]
        public XPCollection<MyAddress> Addresses {
            get { return GetCollection<MyAddress>("Addresses"); }
        }
    }

    [DefaultClassOptions]
    public class MyAddress : BaseObject {
        public MyAddress(Session session) : base(session) { }

        public string FullAddress {
            get { return GetPropertyValue<string>("FullAddress"); }
            set { SetPropertyValue<string>("FullAddress", value); }
        }

        [Association("Person-Addresses")]
        public MyPerson Owner {
            get { return GetPropertyValue<MyPerson>("Owner"); }
            set { SetPropertyValue<MyPerson>("Owner", value); }
        }
    }
}
