namespace Factorio.Interfaces
{
    internal interface IDeploible
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public List<ISurface> SurfacesToDeploy { get; set; }
    }
}
