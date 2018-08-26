using SandboxThreeTier.BLL;
using SandboxThreeTier.Source.DAL;
using SandboxThreeTier.Source.VO;
using System.Collections.Generic;

namespace SandboxThreeTier.Source.BLL
{
    public class AppBLL : IBLL
    {
        AppDAL dal;

        public List<AppVO> Apps { get; set; }

        public AppBLL()
        {
            dal = new AppDAL();
        }

        public void LoadData()
        {
            Apps = dal.Load();
        }

        public void SaveData()
        {

        }
    }
}
