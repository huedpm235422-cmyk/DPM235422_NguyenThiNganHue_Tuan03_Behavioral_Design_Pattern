namespace DPM235422_ChainOfResp_Real_PheDuyet_DP
{
    public abstract class NhanVien
    {
        protected NhanVien _capTren;

        public void SetCapTren(NhanVien capTren)
        {
            _capTren = capTren;
        }

        public abstract void PheDuyetChiPhi(double soTien);
    }
}