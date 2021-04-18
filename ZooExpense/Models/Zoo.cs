using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ZooExpense.Models
{


	[XmlRoot(ElementName = "Lion")]
	public class Lion
	{

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "kg")]
		public int Kg { get; set; }

		[XmlIgnore]
		public double Price { get; set; }
	}

	[XmlRoot(ElementName = "Lions")]
	public class Lions
	{

		[XmlElement(ElementName = "Lion")]
		public List<Lion> Lion { get; set; }
	}

	[XmlRoot(ElementName = "Giraffe")]
	public class Giraffe
	{

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "kg")]
		public int Kg { get; set; }

		[XmlIgnore]
		public double Price { get; set; }
	}

	[XmlRoot(ElementName = "Giraffes")]
	public class Giraffes
	{

		[XmlElement(ElementName = "Giraffe")]
		public List<Giraffe> Giraffe { get; set; }
	}

	[XmlRoot(ElementName = "Tiger")]
	public class Tiger
	{

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "kg")]
		public int Kg { get; set; }

		[XmlIgnore]
		public double Price { get; set; }
	}

	[XmlRoot(ElementName = "Tigers")]
	public class Tigers
	{

		[XmlElement(ElementName = "Tiger")]
		public List<Tiger> Tiger { get; set; }
	}

	[XmlRoot(ElementName = "Zebra")]
	public class Zebra
	{

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "kg")]
		public int Kg { get; set; }

		[XmlIgnore]
		public double Price { get; set; }
	}

	[XmlRoot(ElementName = "Zebras")]
	public class Zebras
	{

		[XmlElement(ElementName = "Zebra")]
		public List<Zebra> Zebra { get; set; }
	}

	[XmlRoot(ElementName = "Wolf")]
	public class Wolf
	{

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "kg")]
		public int Kg { get; set; }

		[XmlIgnore]
		public double Price { get; set; }
	}

	[XmlRoot(ElementName = "Wolves")]
	public class Wolves
	{

		[XmlElement(ElementName = "Wolf")]
		public List<Wolf> Wolf { get; set; }
	}

	[XmlRoot(ElementName = "Piranha")]
	public class Piranha
	{

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "kg")]
		public double Kg { get; set; }

		[XmlIgnore]
		public double Price { get; set; }
	}

	[XmlRoot(ElementName = "Piranhas")]
	public class Piranhas
	{

		[XmlElement(ElementName = "Piranha")]
		public List<Piranha> Piranha { get; set; }
	}

	[XmlRoot(ElementName = "Zoo")]
	public class Zoo
	{

		[XmlElement(ElementName = "Lions")]
		public Lions Lions { get; set; }

		[XmlElement(ElementName = "Giraffes")]
		public Giraffes Giraffes { get; set; }

		[XmlElement(ElementName = "Tigers")]
		public Tigers Tigers { get; set; }

		[XmlElement(ElementName = "Zebras")]
		public Zebras Zebras { get; set; }

		[XmlElement(ElementName = "Wolves")]
		public Wolves Wolves { get; set; }

		[XmlElement(ElementName = "Piranhas")]
		public Piranhas Piranhas { get; set; }
	}
}
