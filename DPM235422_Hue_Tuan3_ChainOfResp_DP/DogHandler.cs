namespace DPM235422_Hue_Tuan3_ChainOfResp_DP
{
    class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Meat")
            {
                return $"Dog: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}