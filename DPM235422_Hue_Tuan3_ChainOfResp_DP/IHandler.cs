namespace DPM235422_Hue_Tuan3_ChainOfResp_DP
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
}