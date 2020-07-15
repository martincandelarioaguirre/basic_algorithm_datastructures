using System;

namespace DesignPatterns.Structural
{
    public interface ILEDTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }

    public class SamsungLedTv : ILEDTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Setting channel number {channelNumber} on Samsung TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning Off: Samsung TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning On: Samsung TV");
        }
    }

    public class SonyLedTv : ILEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Sony TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Sony TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Sony TV");
        }
    }

    public abstract class AbstractRemoteControl
    {
        protected ILEDTV ledTv;
        protected AbstractRemoteControl(ILEDTV ledTv)
        {
            this.ledTv = ledTv;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }

    public class SamsungRemoteControl : AbstractRemoteControl
    {

        public SamsungRemoteControl(ILEDTV ledTv) : base(ledTv)
        {

        }

        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }

        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }

        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
    }

    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILEDTV ledTv) : base(ledTv)
        {
        }
        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }
    }

    public class BridgeTest
    {
        public void Run(){
            SonyRemoteControl sonyRemote = new SonyRemoteControl(new SonyLedTv());
            sonyRemote.SwitchOn();
            sonyRemote.SetChannel(101);
            sonyRemote.SwitchOff();
            Console.WriteLine();
            SamsungRemoteControl samsungRemote = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemote.SwitchOn();
            samsungRemote.SetChannel(202);
            samsungRemote.SwitchOff();
            Console.ReadKey();
        }
    }
}