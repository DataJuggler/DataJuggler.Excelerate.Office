
namespace DataJuggler.Excelerate.Office.HSSF.Record
{
    public class Excel9FileRecord:StandardRecord
    {
        public Excel9FileRecord()
        { 
        
        }
        public Excel9FileRecord(RecordInputStream in1)
        { 
        
        }

        public const short sid = 0x1c0;
        public override short Sid
        {
            get { return sid; }
        }

        protected override int DataSize
        {
            get { return 0; }
        }

        public override void Serialize(DataJuggler.Excelerate.Office.Util.ILittleEndianOutput out1)
        {
            
        }
    }
}
