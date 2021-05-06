namespace VisioAutomation.Power
{
    public class FaceList : NamedNodeList<Elements.Face>
    {
        public FaceList() :
            base(face => face.Name)
        {

        }
    }
}