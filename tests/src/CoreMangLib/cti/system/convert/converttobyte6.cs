using System;

/// <summary>
/// ToByte(System.Int16)
/// </summary>
public class ConvertToByte6
{
    #region Public Methods
    public bool RunTests()
    {
        bool retVal = true;

        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;

        TestLibrary.TestFramework.LogInformation("[Negative]");
        retVal = NegTest1() && retVal;
        retVal = NegTest2() && retVal;

        return retVal;
    }

    #region Positive Test Cases
    public bool PosTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("PosTest1: ToByte should Converts the value of an short to the equivalent byte");

        try
        {
            short mask = 0x00FF;
            short s = TestLibrary.Generator.GetInt16(-55);

            s = (short)(s & mask);
            byte expected = (byte)(s & mask);
            byte actual = Convert.ToByte(s);

            if (actual != expected)
            {
                TestLibrary.TestFramework.LogError("001.1", "ToByte can not Converts the value of an short to the equivalent byte");
                TestLibrary.TestFramework.LogInformation("WARNING [LOCAL VARIABLE] actual = " + actual + ", expected = " + expected + ", s = " + s);
                retVal = false;
            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }
    #endregion

    #region Nagetive Test Cases
    public bool NegTest1()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest1: OverflowException should be thrown when value is greater than Byte.MaxValue");

        try
        {
            short c = 0x0100;

            byte actual = Convert.ToByte(c);

            TestLibrary.TestFramework.LogError("101.1", "OverflowException is not thrown when value is greater than Byte.MaxValue");
            TestLibrary.TestFramework.LogInformation("WARNING [LOCAL VARIABLE] actual = " + actual);
            retVal = false;
        }
        catch (OverflowException)
        {
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("101.0", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }

    public bool NegTest2()
    {
        bool retVal = true;

        TestLibrary.TestFramework.BeginScenario("NegTest2: OverflowException should be thrown when value is less than Byte.MinValue");

        try
        {
            short c = -1;

            byte actual = Convert.ToByte(c);

            TestLibrary.TestFramework.LogError("102.1", "OverflowException is not thrown when value is less than Byte.MinValue");
            TestLibrary.TestFramework.LogInformation("WARNING [LOCAL VARIABLE] actual = " + actual);
            retVal = false;
        }
        catch (OverflowException)
        {
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("102.0", "Unexpected exception: " + e);
            TestLibrary.TestFramework.LogInformation(e.StackTrace);
            retVal = false;
        }

        return retVal;
    }
    #endregion
    #endregion

    public static int Main()
    {
        ConvertToByte6 test = new ConvertToByte6();

        TestLibrary.TestFramework.BeginTestCase("ConvertToByte6");

        if (test.RunTests())
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
}
