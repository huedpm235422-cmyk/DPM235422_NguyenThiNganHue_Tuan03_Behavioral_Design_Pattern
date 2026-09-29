namespace DPM235422_Hue_Tuan3_ChainOfResp_DP
{
    class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}