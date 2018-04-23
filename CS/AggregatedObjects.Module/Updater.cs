using System;

using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;

using DevExpress.ExpressApp.Security;

namespace AggregatedObjects.Module {
    public class Updater : ModuleUpdater {
        public Updater(Session session, Version currentDBVersion) : base(session, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

            Role myAddressPermissions = Session.FindObject<Role>(new BinaryOperator("Name", 
                "AggregatedObjectPermissionsOnly"));
			if(myAddressPermissions == null) {
				myAddressPermissions = new Role(Session);
				myAddressPermissions.Name = "AggregatedObjectPermissionsOnly";                
				myAddressPermissions.AddPermission(new ObjectAccessPermission(typeof(MyPerson), 
                    ObjectAccess.AllAccess, ObjectAccessModifier.Deny));
				myAddressPermissions.AddPermission(new ObjectAccessPermission(typeof(MyAddress), 
                    ObjectAccess.AllAccess, ObjectAccessModifier.Allow));
				myAddressPermissions.Save();
			}

			User userSam = Session.FindObject<User>(new BinaryOperator("UserName", "Sam"));
			if(userSam == null) {
				userSam = new User(Session);
				userSam.UserName = "Sam";
				userSam.FirstName = "Sam";				
                userSam.Roles.Add(myAddressPermissions);
				userSam.Save();
			}
        }
    }
}
