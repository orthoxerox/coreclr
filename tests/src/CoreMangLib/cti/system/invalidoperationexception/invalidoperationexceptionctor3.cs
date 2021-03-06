using System;
/// <summary>
/// InvalidOperationException.ctor(String,Exception) [v-minch]
/// </summary>
public class InvalidOperationExceptionctor3
{
    public static int Main()
    {
        InvalidOperationExceptionctor3 invalidOperationExceptionctor3 = new InvalidOperationExceptionctor3();
        TestLibrary.TestFramework.BeginTestCase("InvalidOperationExceptionctor3");
        if (invalidOperationExceptionctor3.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        retVal = PosTest3() && retVal;
        return retVal;
    }
    #region PositiveTest
    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1:Initialize the InvalidOperationException instance with message and InnerException 1");
        try
        {
            string message = "HelloWorld";
            ArgumentException innerException = new ArgumentException();
            InvalidOperationException myException = new InvalidOperationException(message, innerException);
            if (myException == null || myException.Message != message || !myException.InnerException.Equals(innerException))
            {
                TestLibrary.TestFramework.LogError("001", "the InvalidOperationException with message and innerException instance creating failed");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2:Initialize the InvalidOperationException instance with message and InnerException 2");
        try
        {
            string message = null;
            ArgumentException innerException = new ArgumentException();
            InvalidOperationException myException = new InvalidOperationException(message, innerException);
            if (myException == null || myException.Message == null || !myException.InnerException.Equals(innerException))
            {
                TestLibrary.TestFramework.LogError("003", "Initialize the InvalidOperationException instance with null message not succeed");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("004", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    public bool PosTest3()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest3:Initialize the InvalidOperationException instance with message and InnerException 3");
        try
        {
            string message = null;
            InvalidOperationException myException = new InvalidOperationException(message, null);
            if (myException == null || myException.Message == null || myException.InnerException != null)
            {
                TestLibrary.TestFramework.LogError("005", "Initialize the InvalidOperationException instance with null message and null InnerException not succeed");
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("006", "Unexpect exception:" + e);
            retVal = false;
        }
        return retVal;
    }
    #endregion
}