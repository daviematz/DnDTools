using System.Xml;

namespace DnDTools.Static_Classes
{
    static class XMLEditor
    {
        public static void InitializeFiles(string ContainingFolder)
        {
            // Temporarily borrowed from stack overflow so i can learn
            // HOW THE FREAKING HECK XML EDITING WORKS ASBDGUJBSRFKJGA

            // instantiate XmlDocument and load XML from file
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\test.xml");

            // get a list of nodes - in this case, I'm selecting all <AID> nodes under
            // the <GroupAIDs> node - change to suit your needs
            XmlNodeList nodes = doc.SelectNodes("/Equipment/DataCollections/GroupAIDs/AID");

            // loop through all AID nodes
            foreach (XmlNode node in nodes)
            {
                // grab the "id" attribute
                XmlAttribute idAttribute = node.Attributes["id"];

                // check if that attribute even exists...
                if (idAttribute != null)
                {
                    // if yes - read its current value
                    string currentValue = idAttribute.Value;

                    // here, you can now decide what to do - for demo purposes,
                    // I just set the ID value to a fixed value if it was empty before
                    if (string.IsNullOrEmpty(currentValue))
                    {
                        idAttribute.Value = "515";
                    }
                }
            }

            // save the XmlDocument back to disk
            doc.Save(@"D:\test2.xml");

        }
    }
}
