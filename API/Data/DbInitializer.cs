using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
            {
                	new Product
                {
                    Name = "CSB Latin Machete",
                    Description =
                        "Magnum Chainsaw Backup Machete me një teh të drejtë prej 420 të veshur në këtë version, është veçanërisht i popullarizuar në Amerikën e Jugut.\n Macheta e fortë nuk e lë pronarin e saj në baltë as në pyjet tropikale të shiut dhe është një mjet serioz pyjor për mirembatjen dhe krasitjen e bimeve.\n Konstruksioni i ngurtë me kënd të sheshtë me katër peshore doreze të gomuara të vidhave shtrihet rehat në dorë, ndërsa ekuilibri optimal i trashësisë dhe gjatësisë së tehut, si dhe dizajni ergonomik i dorezës lejojnë punë pa lodhje. Një këllëf najloni i fortë, me një bllokues të dyfishtë me butona, mbron produktin ashtu edhe mbajtësin e saj.",
                    Price = 43,
                    PictureUrl = "https://camouflage-ks.com/files/image/id/21612/fixed/1/w/616/h/762/n/magnum-thik%C3%AB-csb-latin-machete-02ry691-1.jpg",
                    Brand = "Magnum",
                    Type = "Thika dhe Vegla",
                    QuantityInStock = 40
                },
                new Product
                {
                    Name = "Thikë Luftarake \"FORCAVE SPECIALE\" MilTEC",
                    Description = "Thikë luftarake \"FORCAVE SPECIALE\".\n Tehu i gjatë dhe i lëmuar është i pajisur me një sharrë shtesë me dy rreshta. Doreza është bërë prej plastike.\n Mbrojtese shtesë mbron dorën nga rrëshqitja aksidentale në teh.Mbulesa e thikës është e pajisur me dy xhepa najloni, të montuar me Velcro. Brenda njërit prej tyre është vendosur një busull me tela, ndërsa e dyta përmban kompletin e peshkimit, shkrepëset dhe sharrën me tela.",
                    Price = 39,
                    PictureUrl = "https://camouflage-ks.com/files/image/id/19975/fixed/1/w/350/h/433/n/mil-tec-sturm-thik%C3%AB-luftarake-forcave-speciale-15368000-1@2x.png",
                    Brand = "MilTEC",
                    Type = "Thika dhe Vegla",
                    QuantityInStock = 60
                },
                new Product
                {
                    Name = "MIL-TEC STURM ÇANTË - COMBAT DUFFLE BAG WITH WHEEL OLIVE",
                    Description =
                        "Çanta me rrota nga kompania Mil-tec mund të shërbejë si një çantë shpine për shkak të rripave që hiqen të shpinës.",
                    Price = 120,
                    PictureUrl = "https://camouflage-ks.com/files/image/id/20011/fixed/1/w/616/h/762/n/mil-tec-sturm-%C3%87ant%C3%AB-combat-duffle-bag-with-wheel-olive-13854001-1.png",
                    Brand = "MIL Tec",
                    Type = "Çanta",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "HIGHLANDER ÇANTË SHPINE - TRAIL BACKPACK 30L",
                    Description =
                        "Kjo çantë përmban një ndarje kryesore të bollshme me qasje përpara, një ndarje të fshikëzës së hidratimit dhe sythe për shtyllat e ecjes dhe sëpatat e akullit. Materiali është rezistente ndaj ujit dhe ka një këllëf të integruar për të mbajtur veshjet tuaja plotësisht të thata në një stuhi shiu. \nSistemi i pasmë dhe rripi i belit janë të mbushura me shkumë për mbajtje të rehatshme të ngarkesës.",
                    Price = 50,
                    PictureUrl = "https://camouflage-ks.com/files/image/id/20764/fixed/1/w/616/h/762/n/highlander-%C3%87ant%C3%AB-shpine-trail-backpack-30l-ruc263-sl-1.jpg",
                    Brand = "Highlander",
                    Type = "Çanta",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "STOIRM TACTICAL TROUSERS BK",
                    Description =
                        "Pantallonat Taktike Stoirm kanë një ndërtim të fortë ripstop dhe janë ideale për mjedise sfiduese.\n Me panele të zgjatura gjuri për të ndihmuar lëvizjen dhe komoditetin plus me strukturën e tyre të xhepit, mund të jeni të sigurt që të gjithë artikujt tuaj janë të sigurt në vendin e tyre.",
                    Price = 25000,
                    PictureUrl = "https://camouflage-ks.com/files/image/id/21293/fixed/1/w/350/h/433/n/stoirm-stoirm-tactical-trousers-bk-tr144-bk-1@2x.jpg",
                    Brand = "STOIRM",
                    Type = "PANTALLONA",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "SECUBOR EMBLEME ME KRYQ REFLEKTIV",
                    Description =
                        "Kjo steme reprezenton nje simbol te ndihmes se pare!",
                    Price = 5,
                    PictureUrl = "https://camouflage-ks.com/files/image/id/20792/fixed/1/w/616/h/762/n/secubor-embleme-me-kryq-reflektiv-r-med-mtp-1.jpg",
                    Brand = "SECUBOR",
                    Type = "Stema",
                    QuantityInStock = 300
                },
                new Product
                {
                    Name = "SECUBOR EMBLEMË ME LOGO TË UÇK",
                    Description =
                        "Kjo steme reprezenton nje simbol te ushtrise clirimtare te Kosoves UCK!",
                    Price = 5,
                    PictureUrl = "https://camouflage-ks.com/files/image/id/20667/fixed/1/w/616/h/762/n/camouflage-emblem%C3%AB-me-logo-t%C3%AB-u%C3%87k-pvcp-uckr-1.jpg",
                    Brand = "SECUBOR",
                    Type = "Stema",
                    QuantityInStock = 300
                }
            };
            foreach(var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChangesAsync();
        }
    }
}