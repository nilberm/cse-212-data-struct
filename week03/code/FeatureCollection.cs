public class Properties
{
    public double mag { get; set; }
    public string place { get; set; }
}

public class Geometry
{
    public List<double> coordinates { get; set; }
}

public class Feature
{
    public string type { get; set; }
    public Properties properties { get; set; }
    public Geometry geometry { get; set; }
}

public class FeatureCollection
{
    public string type { get; set; }
    public List<Feature> features { get; set; }
}