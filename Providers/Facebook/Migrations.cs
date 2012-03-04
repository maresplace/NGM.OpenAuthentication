using NGM.OpenAuthentication.Providers.Facebook.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using Orchard.Environment.Extensions;

namespace NGM.OpenAuthentication.Providers.Facebook {
    [OrchardFeature("Facebook")]
    public class Migrations : DataMigrationImpl {
        public int Create() {
            ContentDefinitionManager.AlterPartDefinition(typeof(FacebookConnectSignInPart).Name, cfg => cfg.Attachable());

            ContentDefinitionManager.AlterTypeDefinition("FacebookConnectSignInWidget", cfg => cfg
                                                                                                   .WithPart("FacebookConnectSignInPart")
                                                                                                   .WithPart("WidgetPart")
                                                                                                   .WithPart("CommonPart")
                                                                                                   .WithSetting("Stereotype", "Widget"));

            return 1;
        }
    }
}