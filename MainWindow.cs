using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpUpdate;

namespace BaroChecklist
{
    public partial class MainWindow : Form, ISharpUpdatable
    {
        // private Properties.Settings settings = Properties.Settings.Default;
        TreeNode[] fullNodes;
        public MainWindow()
        {
            InitializeComponent();
            this.versionText.Text = Variables.GetVersion();
            this.filterBox.GotFocus += FilterBoxGotFocus;
            this.filterBox.LostFocus += FilterBoxLostFocus;
            this.AutoScroll = true;
            bool allChecked = true;
            fullNodes = BuildTree();
            Checklist.Nodes.AddRange(fullNodes);

            //foreach (TreeNode node in Checklist.Nodes)
            //{
            //    foreach (TreeNode childNode in node.Children())
            //    {
            //        LoadSettings(childNode);
            //
            //        foreach (TreeNode parent in childNode.Parents())
            //        {
            //            allChecked = !parent.Nodes.OfType<TreeNode>().Any(n => !n.Checked);
            //            parent.Checked = allChecked;
            //        }
            //    }
            //}
        }

        void FilterBoxGotFocus(object sender, EventArgs e)
        {
            if(filterBox.Text == "Enter Filter...")
            {
                filterBox.Text = "";
            }
        }

        void FilterBoxLostFocus(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(filterBox.Text))
            {
                filterBox.Text = "Enter Filter...";
            }
        }
        TreeNode[] BuildTree()
        {
            //To store temporary nodes, before adding to final list
            List<TreeNode> tempNodes = new List<TreeNode>();

            TreeNode[] result;

            TreeNode weapons;
            TreeNode mods;

            #region Weapons
            TreeNode primary;
            TreeNode secondary;
            TreeNode melee;
            TreeNode archWeapon;

            AddWeaponPrimary();
            AddWeaponSecondary();
            AddWeaponMelee();
            AddWeaponArchWeapon();
            AddWeapons();

            //TODO Refactor to Switch

            void AddWeaponPrimary()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Weapons/Primary")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                primary = new TreeNode("Weapons_Primary", tempNodes.ToArray());
                primary.Name = primary.Text;
                primary.Text = "Primary";
                tempNodes.Clear();
            }

            void AddWeaponSecondary()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Weapons/Secondary")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                secondary = new TreeNode("Weapons_Secondary", tempNodes.ToArray());
                secondary.Name = secondary.Text;
                secondary.Text = "Secondary";
                tempNodes.Clear();
            }

            void AddWeaponMelee()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Weapons/Melee")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                melee = new TreeNode("Weapons_Melee", tempNodes.ToArray());
                melee.Name = melee.Text;
                melee.Text = "Melee";
                tempNodes.Clear();
            }

            void AddWeaponArchWeapon()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Weapons/ArchWeapon")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                archWeapon = new TreeNode("Weapons_ArchWeapon", tempNodes.ToArray());
                archWeapon.Name = archWeapon.Text;
                archWeapon.Text = "ArchWeapon";
                tempNodes.Clear();
            }

            void AddWeapons()
            {
                tempNodes.Add(primary);
                tempNodes.Add(secondary);
                tempNodes.Add(melee);
                tempNodes.Add(archWeapon);
                weapons = new TreeNode("Weapons", tempNodes.ToArray());
                weapons.Name = "Weapons";
                tempNodes.Clear();
            }
            #endregion

            #region Mods
            TreeNode modsWarframe;
            TreeNode modsPrimary;
            TreeNode modsPistol;
            TreeNode modsShotgun;
            TreeNode modsMelee;
            TreeNode modsArchwing;
            TreeNode modsArchGun;
            TreeNode modsCompanion;

            AddWarframeMods();
            AddPrimaryMods();
            AddPistolMods();
            AddShotgunMods();
            AddMeleeMods();
            AddArchwingMods();
            AddArchGunMods();
            AddCompanionMods();
            AddMods();

            void AddWarframeMods()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Mods/Warframe")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                modsWarframe = new TreeNode("Mods_Warframe", tempNodes.ToArray());
                modsWarframe.Name = modsWarframe.Text;
                modsWarframe.Text = "Warframe";
                tempNodes.Clear();
            }

            void AddPrimaryMods()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Mods/Primary")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                modsPrimary = new TreeNode("Mods_Primary", tempNodes.ToArray());
                modsPrimary.Name = modsPrimary.Text;
                modsPrimary.Text = "Primary";
                tempNodes.Clear();
            }

            void AddPistolMods()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Mods/Pistol")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                modsPistol = new TreeNode("Mods_Pistol", tempNodes.ToArray());
                modsPistol.Name = modsPistol.Text;
                modsPistol.Text = "Pistol";
                tempNodes.Clear();
            }

            void AddShotgunMods()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Mods/Shotgun")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                modsShotgun = new TreeNode("Mods_Shotgun", tempNodes.ToArray());
                modsShotgun.Name = modsShotgun.Text;
                modsShotgun.Text = "Shotgun";
                tempNodes.Clear();
            }

            void AddMeleeMods()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Mods/Melee")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                modsMelee = new TreeNode("Mods_Melee", tempNodes.ToArray());
                modsMelee.Name = modsMelee.Text;
                modsMelee.Text = "Melee";
                tempNodes.Clear();
            }

            void AddArchwingMods()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Mods/Archwing")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                modsArchwing = new TreeNode("Mods_Archwing", tempNodes.ToArray());
                modsArchwing.Name = modsArchwing.Text;
                modsArchwing.Text = "Archwing";
                tempNodes.Clear();
            }

            void AddArchGunMods()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Mods/ArchGun")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                modsArchGun = new TreeNode("Mods_ArchGun", tempNodes.ToArray());
                modsArchGun.Name = modsArchGun.Text;
                modsArchGun.Text = "ArchGun";
                tempNodes.Clear();
            }

            void AddCompanionMods()
            {
                foreach (var item in Variables.itemInfos)
                {
                    TreeNode tempNode = new TreeNode(item.Key);
                    if (item.Value.category == "Mods/Companion")
                    {
                        tempNode.Name = item.Key;
                        tempNode.Text = item.Key;
                        tempNode.Tag = item.Value.tags;
                        tempNodes.Add(tempNode);
                    }
                }
                modsCompanion = new TreeNode("Mods_Companion", tempNodes.ToArray());
                modsCompanion.Name = modsCompanion.Text;
                modsCompanion.Text = "Companion";
                tempNodes.Clear();
            }

            void AddMods()
            {
                tempNodes.Add(modsWarframe);
                tempNodes.Add(modsPrimary);
                tempNodes.Add(modsPistol);
                tempNodes.Add(modsShotgun);
                tempNodes.Add(modsMelee);
                tempNodes.Add(modsArchwing);
                tempNodes.Add(modsArchGun);
                tempNodes.Add(modsCompanion);
                mods = new TreeNode("Mods", tempNodes.ToArray());
                mods.Name = "Mods";
            }

            #endregion
            result = new TreeNode[] { weapons, mods };
            foreach (TreeNode node in result)
            {
                foreach (TreeNode childNode in node.Children())
                {
                    LoadSettings(childNode);

                    //foreach (TreeNode parent in childNode.Parents())
                    //{
                        //allChecked = !parent.Nodes.OfType<TreeNode>().Any(n => !n.Checked);
                        //parent.Checked = allChecked;
                    //}
                }
            }
            return result;
            //Checklist.Nodes.AddRange((new TreeNode[] { weapons, mods }));
        }

        private Size oldSize;

        public string ApplicationName
        {
            get { return "BaroChecklist"; }
        }

        public string ApplicationID
        {
            get { return "BaroChecklist"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri(""); }
        }

        public Form Context
        {
            get { return this; }
        }

        private void MainWindow_Load(object sender, EventArgs e) => oldSize = base.Size;

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldSize = base.Size;
        }
        private void ResizeAll(Control control, Size newSize)
        {
            int width = newSize.Width - oldSize.Width;
            control.Left += (control.Left * width) / oldSize.Width;
            control.Width += (control.Width * width) / oldSize.Width;

            int height = newSize.Height - oldSize.Height;
            control.Top += (control.Top * height) / oldSize.Height;
            control.Height += (control.Height * height) / oldSize.Height;
        }

        private void Checklist_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ItemInfo info = ItemInfo.Blank();
            if (Variables.itemInfos.ContainsKey(e.Node.Name))
            {
                info = Variables.itemInfos[e.Node.Name];
            }
            TreeView list = sender as TreeView;
            TryDisplayImage(e.Node.Name);
            ducatsCost.Text = info.ducatCost != -1 ? String.Format("{0:n0}", info.ducatCost) : "N/A";
            creditsCost.Text = info.creditCost != -1 ? String.Format("{0:n0}", info.creditCost) : "N/A";
            Console.WriteLine(list.SelectedNode.Name + " selected");
        }

        private void Checklist_AfterCheck(object sender, TreeViewEventArgs e)
        {
            bool allChecked = true;
            Console.WriteLine($"Checked Node {e.Node.Name}");

            if (e.Action == TreeViewAction.Unknown)
            {
                Save(e.Node);
                return;
            }

            foreach (TreeNode node in e.Node.Children())
            {
                node.Checked = e.Node.Checked;
            }
            foreach (TreeNode parent in e.Node.Parents())
            {
                allChecked = !parent.Nodes.OfType<TreeNode>().Any(n => !n.Checked);
                parent.Checked = allChecked;
            }

            Save(e.Node);
        }

        void Save(TreeNode node)
        {
            switch (node.Name)
            {
                case "Weapons":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Weapons Save not implemented");
                    Console.ResetColor();
                    break;
                #region Primary
                case "Primary":
                    Properties.Settings.Default.Primary = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;
                case Variables.glaxonVandal:
                    Properties.Settings.Default.Glaxon_Vandal = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;
                case Variables.ignisWraith:
                    Properties.Settings.Default.Ignis_Wraith = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;
                case Variables.opticorVandal:
                    Properties.Settings.Default.Opticor_Vandal = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;
                case Variables.prismaGorgon:
                    Properties.Settings.Default.Prisma_Gorgon = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;
                case Variables.prismaGrakata:
                    Properties.Settings.Default.Prisma_Grakata = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;

                case Variables.prismaGrinlok:
                    Properties.Settings.Default.Prisma_Grinlock = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;

                case Variables.prismaTetra:
                    Properties.Settings.Default.Prisma_Tetra = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;

                case Variables.quantaVandal:
                    Properties.Settings.Default.Quanta_Vandal = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;

                case Variables.supraVandal:
                    Properties.Settings.Default.Supra_Vandal = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;

                case Variables.vulkarWraith:
                    Properties.Settings.Default.Vulkar_Wraith = node.Checked;
                    Console.WriteLine($"Saved {node.Name}");
                    break;
                #endregion
                #region Secondary
                case "Secondary":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Secondary Save not implemented");
                    Console.ResetColor();
                    break;
                #endregion
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{node.Name} Save not implemented");
                    Console.ResetColor();
                    break;
            }
            Properties.Settings.Default.Save();
        }

        void LoadSettings(TreeNode node)
        {

            switch (node.Name)
            {
                case "Weapons":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Weapons Save not implemented");
                    Console.ResetColor();
                    break;
                #region Primary
                case "Primary":
                    node.Checked = Properties.Settings.Default.Primary;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.glaxonVandal:
                    node.Checked = Properties.Settings.Default.Glaxon_Vandal;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.ignisWraith:
                    node.Checked = Properties.Settings.Default.Ignis_Wraith;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.opticorVandal:
                    node.Checked = Properties.Settings.Default.Opticor_Vandal;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.prismaGorgon:
                    node.Checked = Properties.Settings.Default.Prisma_Gorgon;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.prismaGrakata:
                    node.Checked = Properties.Settings.Default.Prisma_Grakata;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.prismaGrinlok:
                    node.Checked = Properties.Settings.Default.Prisma_Grinlock;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.prismaTetra:
                    node.Checked = Properties.Settings.Default.Prisma_Tetra;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.quantaVandal:
                    node.Checked = Properties.Settings.Default.Quanta_Vandal;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.supraVandal:
                    node.Checked = Properties.Settings.Default.Supra_Vandal;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                case Variables.vulkarWraith:
                    node.Checked = Properties.Settings.Default.Vulkar_Wraith;
                    Console.WriteLine($"Loaded {node.Name}");
                    break;
                #endregion
                #region Secondary
                case "Secondary":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Secondary Load not implemented");
                    Console.ResetColor();
                    break;
                #endregion
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{node.Name} Save not implemented");
                    Console.ResetColor();
                    break;
            }
            bool allChecked = false;
            foreach (TreeNode parent in node.Parents())
            {
                allChecked = !parent.Nodes.OfType<TreeNode>().Any(n => !n.Checked);
                parent.Checked = allChecked;
            }


        }

        void TryDisplayImage(String itemName)
        {
            itemPicture.Image = Utils.ResizeImage(Variables.ItemImage(itemName), itemPicture);
        }

        private void filterBox_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            Console.WriteLine($"Filter Changed: {sender.ToString()}");
            if (filterBox.Text != "Enter Filter...")
            {
                FilterList(box.Text);
            }
        }

        void FilterList(string filter)
        {
            List<TreeNode> filteredNodes = new List<TreeNode>();

            List<TreeNode> tempWeaponsNodes = new List<TreeNode>();
            List<TreeNode> tempPrimaryNodes = new List<TreeNode>();
            List<TreeNode> tempSecondaryNodes = new List<TreeNode>();
            List<TreeNode> tempMeleeNodes = new List<TreeNode>();
            List<TreeNode> tempArchWeaponNodes = new List<TreeNode>();
            TreeNode weapons;
            TreeNode primary;
            TreeNode secondary;
            TreeNode melee;
            TreeNode archWeapon;

            if (!String.IsNullOrEmpty(filter) || !String.IsNullOrWhiteSpace(filter))
            {
                string split = ",";
                string[] firstTerms = filter.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                List<string> terms = firstTerms.ToList();
                bool nameSearch = false;
                for (int i = 0; i < firstTerms.Length; i++)
                {
                    int index = i;
                    if (firstTerms[index].Equals(","))
                    {
                        Console.WriteLine($"Removing: {firstTerms[index]} | {terms[index]}");
                        terms.RemoveAt(index);
                    }
                }
                Checklist.Nodes.Clear();

                foreach (TreeNode rootNode in fullNodes)
                {

                    foreach (TreeNode node in rootNode.Children())
                    {
                        if (terms.Any(word => Variables.itemInfos.ReturnKeyIfValueExist(node.Name).name.Contains(word)))
                        {
                            nameSearch = true;
                            filteredNodes.Add(node);
                        }
                        if (!nameSearch)
                        {
                            if (terms.Any(word => Variables.itemInfos.ReturnKeyIfValueExist(node.Name).tags.Contains(word.ToTitleCase())))
                            {
                                //switch (Variables.itemInfos.ReturnKeyIfValueExist(node.Name).category)
                                //{
                                //    case "Weapons/Primary":
                                //        tempPrimaryNodes.Add(node);
                                //        break;
                                //    case "Weapons/Secondmary":
                                //        tempSecondaryNodes.Add(node);
                                //        break;
                                //    case "Weapons/Melee":
                                //        tempMeleeNodes.Add(node);
                                //        break;
                                //    default:
                                //        break;
                                //}
                                //primary = new TreeNode("Weapons_Primary", tempPrimaryNodes.ToArray());
                                //secondary = new TreeNode("Weapons_Secondary", tempSecondaryNodes.ToArray());
                                //melee = new TreeNode("Weapons_Melee", tempMeleeNodes.ToArray());
                                //tempWeaponsNodes.Add(primary);
                                //tempWeaponsNodes.Add(secondary);
                                //tempWeaponsNodes.Add(melee);
                                //weapons = new TreeNode("Weapons", tempWeaponsNodes.ToArray());
                                filteredNodes.Add(node);
                                //node.ForeColor = Color.Green;
                                if (terms.Any(word => !Variables.itemInfos.ReturnKeyIfValueExist(node.Name).tags.Contains(word)))
                                {
                                    filteredNodes.Remove(node);
                                    //node.ForeColor = Color.Black;
                                }
                            }
                            else
                            {
                                node.ForeColor = Color.Black;
                            }
                        }
                    }
                }
                Checklist.Nodes.AddRange(filteredNodes.ToArray());
            }
            else
            {
                Checklist.Nodes.Clear();
                Checklist.Nodes.AddRange(BuildTree());
                Checklist.Refresh();
            }
        }

        private void filterTextBox_Hover(object sender, EventArgs e)
        {
            filterTextTooltip.Show("Filter List using comma seperated terms.\n ex: Mods,Primary", filterBox);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SharpUpdater updater = new SharpUpdater(this);
            updater.DoUpdate();
        }
    }
}
