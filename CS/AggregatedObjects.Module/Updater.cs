using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;

namespace AggregatedObjects.Module {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            Role myAddressPermissions = ObjectSpace.FindObject<Role>(new BinaryOperator("Name", 
                "AggregatedObjectPermissionsOnly"));
			if(myAddressPermissions == null) {
				myAddressPermissions = ObjectSpace.CreateObject<Role>();
				myAddressPermissions.Name = "AggregatedObjectPermissionsOnly";                
				myAddressPermissions.AddPermission(new ObjectAccessPermission(typeof(MyPerson), 
                    ObjectAccess.AllAccess, ObjectAccessModifier.Deny));
				myAddressPermissions.AddPermission(new ObjectAccessPermission(typeof(MyAddress), 
                    ObjectAccess.AllAccess, ObjectAccessModifier.Allow));
				myAddressPermissions.Save();
			}

			User userSam = ObjectSpace.FindObject<User>(new BinaryOperator("UserName", "Sam"));
			if(userSam == null) {
				userSam = ObjectSpace.CreateObject<User>();
				userSam.UserName = "Sam";
				userSam.FirstName = "Sam";				
                userSam.Roles.Add(myAddressPermissions);
				userSam.Save();
			}
        }
    }
}
