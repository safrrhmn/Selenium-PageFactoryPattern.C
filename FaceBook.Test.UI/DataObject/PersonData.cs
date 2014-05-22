using FaceBook.Test.UI.Model;

namespace FaceBook.Test.UI.DataObject
{
    public class PersonData
    {
        public static UserDetailModel ValidUserData()
        {
			return new UserDetailModel
            {
                UserLoginEmail = "akbar.qast@yahoo.com",
                UserLoginPassword = "Bangladesh1234",
				InviteFriendEmail = "TestEmail@Test.com"
            };
        }
    }
}