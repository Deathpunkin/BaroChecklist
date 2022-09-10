using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace BaroChecklist
{
    class Variables
    {

        public static string GetVersion()
        {
            return Assembly.GetEntryAssembly().GetName().Version.ToString();
        }

        #region Weapons
        //Primary
        public const string glaxonVandal = "Glaxon Vandal";
        public const string ignisWraith = "Ignis Wraith";
        public const string opticorVandal = "Opticor Vandal";
        public const string prismaGorgon = "Prisma Gorgon";
        public const string prismaGrakata = "Prisma Grakata";
        public const string prismaGrinlok = "Prisma Grinlok";
        public const string prismaTetra = "Prisma Tetra";
        public const string quantaVandal = "Quanta Vandal";
        public const string supraVandal = "Supra Vandal";
        public const string vulkarWraith = "Vulkar Wraith";

        //Secondary
        public const string maraDetron = "Mara Detron";
        public const string prismaAngstrum = "Prisma Angstrum";
        public const string prismaTwinGremlins = "Prisma Twin Gremlins";
        public const string viperWraith = "Viper Wraith";
        public const string zylok = "Zylok";

        //Melee
        public const string halikarWraith = "Halikar Wraith";
        public const string macheteWraith = "Machete Wraith";
        public const string prismaDualCleavers = "Prisma Dual Cleavers";
        public const string prismaSkana = "Prisma Skana";
        public const string prismaObex = "Prisma Obex";
        public const string provaVandal = "Prova Vandal";
        public const string vastilok = "Vastilok";

        //Archweapons
        public const string prismaDualDecurion = "Prisma Dual Decurion";
        public const string prismaVeritux = "Prisma Veritux";
        #endregion

        #region Mods
        #region Warframe
        public const string primedContinuity = "Primed Continuity";
        public const string primedFlow = "Primed Flow";
        public const string peculiarAudience = "Peculiar Audience";
        #endregion
        #region Weapons
        #region Primary
        public const string primedBaneOfCorpus = "Primed Bane of Corpus";
        public const string primedBaneOfCorrupted = "Primed Bane of Corrupted";
        public const string primedBaneOfGrineer = "Primed Bane of Grineer";
        public const string primedBaneOfInfested = "Primed Bane of Infested";
        public const string primedCryoRounds = "Primed Cryo Rounds";
        public const string primedFastHands = "Primed Fast Hands";
        public const string primedFirestorm = "Primed Firestorm";
        public const string primedMagazineWarp = "Primed Magazine Warp";
        public const string primedRifleAmmoMutation = "Primed Rifle Ammo Mutation";
        public const string primedSniperAmmoMutation = "Primed Sniper Ammo Mutation";
        public const string highVoltage = "High Voltage";
        public const string crashCourse = "Crash Course";
        public const string fangedFusillade = "Fanged Fusillade";
        public const string primedChamber = "Primed Chamber";
        public const string splitFlights = "Split Flights";
        #endregion
        #region Pistol
        public const string primedExpelCorpus = "Primed Expel Corpus";
        public const string primedExpelCorrupted = "Primed Expel Corrupted";
        public const string primedExpelGrineer = "Primed Expel Grineer";
        public const string primedExpelInfested = "Primed Expel Infested";
        public const string primedFulmination = "Primed Fulmination";
        public const string primedHeatedCharge = "Primed Heated Charge";
        public const string primedPistolGambit = "Primed Pistol Gambit";
        public const string primedPistolAmmoMutation = "Primed Pistol Ammo Mutation";
        public const string primedQuickdraw = "Primed Quickdraw";
        public const string primedSlipMagazine = "Primed Slip Magazine";
        public const string primedTargetCracker = "Primed Target Cracker";
        public const string pummel = "Pummel";
        public const string scorch = "Scorch";
        public const string jolt = "Jolt";
        public const string maim = "Maim";
        #endregion
        #region Shotgun
        public const string primedAmmoStock = "Primed Ammo Stock";
        public const string primedChargedShell = "Primed Charged Shell";
        public const string primedChillingGrasp = "Primed Chilling Grasp";
        public const string primedCleanseCorpus = "Primed Cleanse Corpus";
        public const string primedCleanseCorrupted = "Primed Cleanse Corrupted";
        public const string primedCleanseGrineer = "Primed Cleanse Grineer";
        public const string primedCleanseInfested = "Primed Cleanse Infested";
        public const string primedPointBlank = "Primed Point Blank";
        public const string primedRavage = "Primed Ravage";
        public const string primedShotgunAmmoMutation = "Primed Shotgun Ammo Mutation";
        public const string primedTacticalPump = "Primed Tactical Pump";
        public const string scatteringInferno = "Scattering Inferno";
        public const string shellShock = "Shell Shock";
        public const string sweepingSerration = "Sweeping Serration";
        public const string fullContact = "Full Contact";
        #endregion
        #region Melee
        public const string primedFeverStrike = "Primed Fever Strike";
        public const string primedHeavyTrauma = "Primed Heavy Trauma";
        public const string primedPressurePoint = "Primed Pressure Point";
        public const string primedReach = "Primed Reach";
        public const string primedSmiteCorpus = "Primed Smite Corpus";
        public const string primedSmiteCorrupted = "Primed Smite Corrupted";
        public const string primedSmiteGrineer = "Primed Smite Grineer";
        public const string primedSmiteInfested = "Primed Smite Infested";
        public const string buzzKill = "Buzz Kill";
        public const string collisionForce = "Collision Force";
        public const string volcanicEdge = "Volcanic Edge";
        public const string comboFury = "Combo Fury";
        public const string voltaicStrike = "Voltaic Strike";
        public const string comboKiller = "Combo Killer";
        public const string markOfTheBeast = "Mark of the Beast";
        public const string astralTwilight = "Astrl Twilight";
        public const string tempoRoyale = "Tempo Royale";
        public const string vermillionStorm = "Vermillion Storm";
        #endregion
        #endregion
        #region Archwing
        public const string primedMorphicTransformer = "Primed Morphic Transformer";
        public const string primedRubedoLinedBarrel = "Primed Rubedo-Lined Barrel";
        #endregion
        #region Companion
        public const string primedAnimalInstinct = "Primed Animal Instinct";
        public const string primedPackLeader = "Primed Pack Leader";
        public const string primedRegen = "Primed Regen";
        #endregion
        #endregion

        #region Cosmetics
        #region Warframe
        public const string chromaImmortalSkin = "Chroma Immortal Skin";
        public const string garaImmortalSkin = "Gara Immortal Skin";
        public const string hydroidImmortalSkin = "Hydroid Immortal Skin";
        public const string limboImmortalSkin = "Limbo Immortal Skin";
        public const string mesaImmortalSkin = "Mesa Immortal Skin";
        public const string mirageImmortalSkin = "Mirage Immortal Skin";
        public const string nidusImmortalSkin = "Nidus Immortal Skin";
        public const string zephyrImmortalSkin = "Zephyr Immortal Skin";
        public const string faePathEphemera = "Fae Path Ephemera";
        public const string kiteerEphemera = "Ki'teer Ephemera";
        public const string lotusEphemera = "Lotus Ephemera";
        #endregion
        #region Armor

        #endregion
        #endregion

        public static Image placeHolderImage = Properties.Resources.Image_Work_In_Progress;
        public static Image errorImage = Properties.Resources.Image_Error;

        public static Dictionary<string, ItemInfo> itemInfos = new Dictionary<string, ItemInfo>()
        {
            //{"", new ItemInfo
            //{
            //    name = "",
            //    category = "",
            //    ducatCost = -1,
            //    creditCost = -1,
            //    tags = ""
            //} },
            #region Weapons
            #region Primary
            {glaxonVandal, new ItemInfo
            {
                name = glaxonVandal,
                category = "Weapons/Primary",
                ducatCost = 475,
                creditCost = 250000,
                tags = "Weapon,Primary,Vandal,Cold,Rifle"}},
            {ignisWraith, new ItemInfo
            {
                name = ignisWraith,
                category = "Weapons/Primary",
                ducatCost = 550,
                creditCost = 250000,
                tags = "Weapon,Primary,Wraith,Heat,Rifle"} },
            {opticorVandal, new ItemInfo
            {
                name = opticorVandal,
                category = "Weapons/Primary",
                ducatCost = 650,
                creditCost = 550000,
                tags = "Weapon,Primary,Vandal,Rifle,Magnetic"
            } },
            {prismaGorgon, new ItemInfo
            {
                name = prismaGorgon,
                category = "Weapons/Primary",
                ducatCost = 600,
                creditCost = 50000,
                tags = "Weapon,Primary,Prisma,Rifle"}},
            {prismaGrakata, new ItemInfo
            {
                name = prismaGrakata,
                category = "Weapons/Primary",
                ducatCost = 610,
                creditCost = 100000,
                tags = "Weapon,Primary,Prisma,Rifle"} },
            {prismaGrinlok, new ItemInfo
            {
                name = prismaGrinlok,
                category = "Weapons/Primary",
                ducatCost = 500,
                creditCost = 220000,
            tags = "Weapon,Primary,Prisma,Rifle"} },
            {prismaTetra, new ItemInfo
            {
                name = prismaTetra,
                category = "Weapons/Primary",
                ducatCost = 400,
                creditCost = 50000,
                tags = "Weapon,Primary,Prisma,Rifle"} },
            {quantaVandal, new ItemInfo
            {
                name = quantaVandal,
                category = "Weapons/Primary",
                ducatCost = 450,
                creditCost = 300000,
                tags = "Weapon,Primary,Vandal,Rifle"} },
            {supraVandal, new ItemInfo
            {
                name = supraVandal,
                category = "Weapons/Primary",
                ducatCost = 500,
                creditCost = 275000,
                tags = "Weapon,Primary,Vandal,Rifle"} },
            {vulkarWraith, new ItemInfo
            {
                name = vulkarWraith,
                category = "Weapons/Primary",
                ducatCost = 450,
                creditCost = 300000,
                tags = "Weapon,Primary,Wraith,Rifle"} },
            #endregion

            #region Secondary
            {maraDetron, new ItemInfo
            {
                name = maraDetron,
                category = "Weapons/Secondary",
                ducatCost = 500,
                creditCost = 200000,
                tags = "Weapon,Secondary,Mara,Shotgun,Radiation"} },
            {prismaAngstrum, new ItemInfo
            {
                name = prismaAngstrum,
                category = "Weapons/Secondary",
                ducatCost = 457,
                creditCost = 210000,
                tags = "Weapon,Secondary,Prisma,Pistol,Blast"} },
            {prismaTwinGremlins, new ItemInfo
            {
                name = prismaTwinGremlins,
                category = "",
                ducatCost = 500,
                creditCost = 220000,
                tags = "Weapon,Secondary,Prisma,Dual Pistols"} },
            {viperWraith, new ItemInfo
            {
                name = viperWraith,
                category = "Weapons/Secondary",
                ducatCost = 400,
                creditCost = 75000,
                tags = "Weapon,Secondary,Wraith,Pistol"} },
            {zylok, new ItemInfo
            {
                name = zylok,
                category = "Weapons/Secondary",
                ducatCost = 500,
                creditCost = 200000,
                tags = "Weapon,Secondary,Pistol"} },
            #endregion

            #region Melee
            {halikarWraith, new ItemInfo
            {
                name = halikarWraith,
                category = "Weapons/Melee",
                ducatCost = 450,
                creditCost = 350000,
                tags = "Weapon,Melee,Wraith,Glaive"} },
            {macheteWraith, new ItemInfo
            {
                name = macheteWraith,
                category = "Weapons/Melee",
                ducatCost = 410,
                creditCost = 250000,
                tags = "Weapon,Melee,Wraith,Sword"} },
            {prismaDualCleavers, new ItemInfo
            {
                name = prismaDualCleavers,
                category = "Weapons/Melee",
                ducatCost = 490,
                creditCost = 200000,
                tags = "Weapon,Melee,Prisma,Dual Swords"} },
            {prismaSkana, new ItemInfo
            {
                name = prismaSkana,
                category = "Weapons/Melee",
                ducatCost = 510,
                creditCost = 175000,
                tags = "Weapon,Melee,Prisma,Sword"
            } },
            {prismaObex, new ItemInfo
            {
                name = prismaObex,
                category = "Weapons/Melee",
                ducatCost = 500,
                creditCost = 175000,
                tags = "Weapon,Melee,Prisma,Sparring"} },
            {provaVandal, new ItemInfo
            {
                name = provaVandal,
                category = "Weapons/Melee",
                ducatCost = 410,
                creditCost = 250000,
                tags = "Weapons,Melee,Vandal,Machete,Electricity"
            } },
            {vastilok, new ItemInfo
            {
                name = vastilok,
                category = "Weapons/Melee",
                ducatCost = 550,
                creditCost = 325000,
                tags = "Weapon,Melee,Gunblade"
            } },
            #endregion

            //Arch-Weapon
            {prismaDualDecurion, new ItemInfo
            {
                name = prismaDualDecurion,
                category = "Weapons/ArchWeapon",
                ducatCost = 525,
                creditCost = 175000,
                tags = "Weapon,Arch-Gun,Prisma"} },
            {prismaVeritux, new ItemInfo
            {
                name = prismaVeritux,
                category = "Weapons/ArchWeapon",
                ducatCost = 550,
                creditCost = 150000,
                tags = "Weapon,Arch-Melee,Prisma"} },
            #endregion

            #region Mods
            #region Warframe
            {primedContinuity, new ItemInfo
            {
                name = primedContinuity,
                category = "Mods/Warframe",
                ducatCost = 350,
                creditCost = 100000,
                tags = "Mods,Warframe,Primed"
            } },
            {primedFlow, new ItemInfo
            {
                name = primedFlow,
                category = "Mods/Warframe",
                ducatCost = 350,
                creditCost = 110000,
                tags = "Mods,Warframe,Primed"
            } },
            #endregion
            #region Primary
            {peculiarAudience, new ItemInfo
            {
                name = peculiarAudience,
                category = "Mods/Warframe",
                ducatCost = 200000,
                creditCost = 250,
                tags = "Mods,Warframe,Peculiar"
            } },
            {primedBaneOfCorpus, new ItemInfo
            {
                name = primedBaneOfCorpus,
                category = "Mods/Primary",
                ducatCost = 400,
                creditCost = 140000,
                tags = "Mods,Weapon,Primary,Primed,Faction,Corpus"
            } },
            {primedBaneOfCorrupted, new ItemInfo
            {
                name = primedBaneOfCorrupted,
                category = "Mods/Primary",
                ducatCost = -1,
                creditCost = -1,
                tags = "Mods,Weapon,Primary,Primed,Faction,Corrupted"
            } },
            {primedBaneOfGrineer, new ItemInfo
            {
                name = primedBaneOfGrineer,
                category = "Mods/Primary",
                ducatCost = -1,
                creditCost = -1,
                tags = "Mods,Weapon,Primary,Primed,Faction,Grineer"
            } },
            {primedBaneOfInfested, new ItemInfo
            {
                name = primedBaneOfInfested,
                category = "Mods/Primary",
                ducatCost = -1,
                creditCost = -1,
                tags = "Mods,Weapon,Primary,Primed,Faction,Infested"
            } },
            {primedCryoRounds, new ItemInfo
            {
                name = primedCryoRounds,
                category = "Mods/Primary",
                ducatCost = -1,
                creditCost = -1,
                tags = "Mods,Weapon,Primary,Primed,Cold"
            } },
            {primedFastHands, new ItemInfo
            {
                name = primedFastHands,
                category = "Mods/Primary",
                ducatCost = -1,
                creditCost = -1,
                tags = "Mods,Weapon,Primary,Primed"
            } },
            {primedFirestorm, new ItemInfo
            {
                name = primedFirestorm,
                category = "Mods/Primary",
                ducatCost = -1,
                creditCost = -1,
                tags = "Mods,Weapon,Primary,Primed,Blast"
            } },
            {primedMagazineWarp, new ItemInfo
            {
                name = primedMagazineWarp,
                category = "Mods/Primary",
                ducatCost = -1,
                creditCost = -1,
                tags = "Mods,Weapon,Primary,Primed"
            } },
            {primedRifleAmmoMutation, new ItemInfo
            {
                name = primedRifleAmmoMutation,
                category = "Mods/Primary",
                ducatCost = -1,
                creditCost = -1,
                tags = "Mods,Weapon,Primary,Primed"
            } },
            {primedSniperAmmoMutation, new ItemInfo
            {
                name = primedSniperAmmoMutation,
                category = "Mods/Primary",
                ducatCost = -1,
                creditCost = -1,
                tags = "Mods,Weapon,Primary,Primed"
            } },
            #endregion
            #region Pistol

            #endregion
            #endregion
        };

        public static Dictionary<string, Image> itemImages = new Dictionary<string, Image>
        {
#region Weapons
            { "Weapons", placeHolderImage },

            { "Weapons_Primary", placeHolderImage },
            //Primary
            { glaxonVandal, Properties.Resources.Image_Glaxion_Vandal},
            { ignisWraith, Properties.Resources.Image_Ignis_Wraith },
            { prismaGorgon, Properties.Resources.Image_Prisma_Gorgon },
            { prismaGrakata, Properties.Resources.Image_Prisma_Grakata },
            { prismaGrinlok, Properties.Resources.Image_Prisma_Grinlok },
            { prismaTetra, Properties.Resources.Image_Prisma_Tetra },
            { quantaVandal, Properties.Resources.Image_Quanta_Vandal },
            { supraVandal, Properties.Resources.Image_Supra_Vandal },
            { vulkarWraith, Properties.Resources.Image_Vulkar_Wraith },

            { "Weapons_Secondary", placeHolderImage },
            //Secondary
            { maraDetron, Properties.Resources.Image_Mara_Detron },
            { prismaAngstrum, Properties.Resources.Image_Prisma_Angstrum },
            { prismaTwinGremlins, Properties.Resources.Image_Prisma_TwinGremlins },
            { viperWraith, Properties.Resources.Image_Viper_Wraith },
            { zylok, Properties.Resources.Image_Zylok },

            { "Weapons_Melee", placeHolderImage },
            //Melee
            { halikarWraith, Properties.Resources.Image_Halikar_Wraith },
            { macheteWraith, Properties.Resources.Image_Machete_Wraith },
            { prismaDualCleavers, Properties.Resources.Image_Prisma_DualCleavers },
            { prismaObex, Properties.Resources.Image_Prisma_Obex },

            { "Weapons_ArchWeapon", placeHolderImage },
            //Archweapons
            { prismaDualDecurion, Properties.Resources.Image_Prisma_DualDecurions },
            { prismaVeritux, Properties.Resources.Image_Prisma_Veritux },
#endregion
        };

        public static Image ItemImage(string itemName)
        {
            if(!itemImages.ContainsKey(itemName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{itemName} not found in itemImages dict.");
                Console.ResetColor();

                return errorImage;
            }
            try
            {
                return itemImages[itemName];
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{itemName} does not have an image specified.");
                Console.ResetColor();
            }
            return errorImage;
        }
    }

    public struct ItemInfo
    {
        public string name;
        public string category;
        public int ducatCost;
        public int creditCost;
        public string tags;

        public static ItemInfo Blank()
        {
            return new ItemInfo
            {
                name = "",
                category = "",
                ducatCost = -1,
                creditCost = -1,
                tags = ""
            };
        }
    }
}
