using gudusoft.gsqlparser;
using gudusoft.gsqlparser.Units;
using Sql2Code.Business.Tokenizer;
using SqlFormatter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sql2Code
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var sql = @"ALTER PROCEDURE [dbo].[p_insert_CallRecord_WebService_v2]
@callDate varchar(6),
@connectTime varchar(6),
@FacilityID int,
@AgentID    int,
@fromNo varchar(10),
@toNo varchar(18),
@fromState varchar(2),
@fromCity varchar(10),
@toState varchar(2),
@toCity varchar(10),
@creditCardType varchar(1),
@creditCardNo varchar(20),   
@creditCardExp varchar(4),
@zipcode varchar(10),
@cvv varchar(4),
@BillType varchar(2) , 
@callType varchar(2), 
@userName varchar(23),
@errorCode tinyint,
@firstMinute        numeric(6, 4),
@addMinute numeric(6,4),
@connectFee numeric(6,4),
@Surcharge numeric(6,4),
@MinDuration smallint,
@ratePlanID     varchar(7),
@responseCode       char(3),
@increment tinyint,
@RecordFileName varchar(20),
@channel smallint,
@folderDate     varchar(8),
@inmateID varchar(12),
@PIN varchar(12),
@InRecordFile varchar(12),
@RecordID bigint,
@UserLanguage  tinyint
 AS
BEGIN
    SET NOCOUNT ON;
            Declare @YY  char(2), @MM char(2), @tblCall varchar(20),  @SQL varchar(500),  @callPeriod  char(1), @HH smallint, @trunKID varchar(4) ,@settlementCode   char(1),  @billToNo char(10);
            Declare @totalSurcharge  numeric(4, 2)  , @SChannel varchar(3), @status char(1) ,  @timeZone tinyint, @recordDate datetime ,@RateClass     char(1), @duration int;
            SET @trunKID = '';
            SET @YY = right(@callDate, 2);
            SET @MM = Left(@callDate, 2);
            SET @RateClass = '6';
            If(@callType = '' or @callType is null)

        SET @callType = 'NA';
            if (@creditcardno <> '' and @billtype = '01') 
		SET @billtype = '05';
            If(@BillType = '08'  or  @billtype = '13')

     Begin
        SET @fromstate = '';
            SET @fromCity = '';
            SET @toState = '';
            SET @toCity = '';
            SET @Surcharge = 0;
            SET @firstMinute = 0;
            SET @addMinute = 0;
            SET @connectFee = 0;
            SET @callType = 'NA';
            End
           Else If(@BillType = '' or @BillType is null)

            SET @BillType = '09';
            Else
             Begin


        IF @BillType = '01'

            SET @billToNo = @toNo;
            End

    if (ltrim(@PIN) = '')
                begin
                      SET @PIN = '0';
            SET @InmateID = '0';
            end

            ---- get local time using GTM time zone
            SET @recordDate = dbo.fn_get_local_time_by_GTM_time_zone(@FacilityID);

            Set @settlementCode = dbo.[fn_determine_setlementCode](@fromState, @toState, '0', '0');

            if (@errorCode > 0)
                begin
                   SET @duration = 0;
            if (@pin <> '0')
                begin
                    Delete tblinmateOncall where(InmateID = @inmateID) and facilityID = @FacilityID;
            end
        end


     INSERT INTO  tblOnCalls(RecordID, Calldate, ConnectTime, FromNo, ToNo, BillToNo, MethodOfRecord, billType, callType, FromState, FromCity,
        ToState, ToCity, CallPeriod, CreditCardType, CreditCardNo, CreditCardExp, CreditCardCvv, CreditCardZip, settlementCode,
         userName, errorCode, rateClass, firstMinute, nextMinute, connectFee, TotalSurcharge, MinDuration, recordDate, ratePlanID, ResponseCode,
        AgentID, RecordFile, MinIncrement, channel, folderDate, InmateID, PIN, facilityID, InRecordFile, lastModify, duration, UserLanguage, phonetype)

     Values(@RecordID, @Calldate, @ConnectTime, @FromNo, @ToNo, @BillToNo, '04', @billType, @callType, @FromState, @FromCity,
        @ToState, @ToCity, @CallPeriod, @creditCardType, @creditCardNo, @creditCardExp, @cvv, @zipcode, @settlementCode,
        @UserName, @errorCode, @RateClass, @firstMinute, @addMinute, @connectFee, @Surcharge, @MinDuration, @recordDate, @ratePlanID, @ResponseCode,
         @AgentID, @RecordFileName, @increment, @channel, @folderDate, @inmateID, @PIN, @facilityID, @InRecordFile, @recordDate, @duration, @UserLanguage, dbo.p_determine_phonetype(@ToNo));


            If(@errorCode = 0)

     Begin


        If(@billtype > 19)

            EXEC p_insert_unbilled_calls_v2  @calldate,@connecttime,  @fromno  ,@tono  ,@billtype  ,@errorCode ,@PIN       ,@inmateID  ,@facilityID    ,@userName,@responseCode, '',@creditCardNo,  @RecordDate,@callType, @RecordID, 0, '' , @UserLanguage;
            --else if (@billtype = '07')
                --update tblDebit set status = 2, userName = 'Oncall', modifyDate = GETDATE() where AccountNo = @creditCardNo;

        else if (@billtype = '10')
                update tblprepaid set userName = 'Oncall'  where phoneno = @billtono;
            EXEC Leg_LiveCast.dbo.p_update_live_call
                                                @FromNo,
                                                @FacilityID,
                                                @recordID,

                                            'Active',
											@InmateID ,
											@ToNo       ,
											@toCity     ,
											@toState   ,
											@userName,
											@recordDate;

            end
           Else

      Begin

        If(@errorCode < '75')

            EXEC p_insert_unbilled_calls_v2  @calldate,@connecttime,  @fromno  ,@tono  ,@billtype  ,@errorCode ,@PIN       ,@inmateID  ,@facilityID    ,@userName,@responseCode, '',@creditCardNo,  @RecordDate,@callType, @RecordID, 0, '' , @UserLanguage;
            if (@BillType = '07')
                Update tbldebit set modifydate = getdate(), status = 1 where FacilityID = @FacilityID and InmateID = @inmateID;

        else if (@BillType = '10')
                Update tblprepaid set modifydate = getdate(), status = 1 where PhoneNo = @toNo;
            End



    If(@PIN > '0')

     begin
        Declare @NameRecordOpt tinyint, @BioMetricOpt tinyint, @NameRecorded tinyint, @BioRegister tinyint;
            SET @NameRecordOpt = 0;
            SET @BioMetricOpt = 0;
            SET @NameRecorded = 0;
            SET @BioRegister = 0;
            Select @NameRecordOpt = NameRecord, @BioMetricOpt = BioMetric  from tblFacilityOption with(nolock) where facilityID = @facilityID;
            if (@NameRecordOpt = 1 or @BioMetricOpt = 1)
		 begin
            select  @NameRecorded = ISNULL(NameRecorded, 0), @BioRegister = BioRegister  from tblInmate with(nolock) where facilityID = @facilityID and PIN = @pin and InmateID = @inmateID;
            if (@NameRecordOpt = 1 and @BioMetricOpt = 1 and(@BioRegister = 0 or @NameRecorded = 0))
				Update tblInmate set NameRecorded = 1, BioRegister = 1 where facilityID = @facilityID and PIN = @pin and InmateID = @inmateID;

            else if (@NameRecordOpt = 1 and @BioMetricOpt = 0  and @NameRecorded = 0)
				Update tblInmate set NameRecorded = 1 where facilityID = @facilityID and PIN = @pin and InmateID = @inmateID;

            else if (@NameRecordOpt = 0 and @BioMetricOpt = 1  and @BioRegister = 0)
				Update tblInmate set BioRegister = 1 where facilityID = @facilityID and PIN = @pin and InmateID = @inmateID;

            end
        end


    if (@@error = 0)
	  select '1' as SetCalls;

    else
                select '0' as SetCalls;
            END";


            //var tokenizer = new SqlFormatter.Tokenizers.TSqlStandardTokenizer();
            //var formatter = new SqlFormattingManager();

            //var formattedSql = formatter.Format(sql);
            //var tokenList = tokenizer.TokenizeSQL(formattedSql);


            var parser = new gudusoft.gsqlparser.TGSqlParser(gudusoft.gsqlparser.TDbVendor.DbVMssql);

            lzbasetype.gFmtOpt.Select_Columnlist_Style = TAlignStyle.asStacked;
            lzbasetype.gFmtOpt.Select_Columnlist_Comma = TLinefeedsCommaOption.lfAfterComma;
            lzbasetype.gFmtOpt.SelectItemInNewLine = false;
            lzbasetype.gFmtOpt.AlignAliasInSelectList = true;
            lzbasetype.gFmtOpt.TreatDistinctAsVirtualColumn = false;
            lzbasetype.gFmtOpt.Parameters_align_option = TAlignOption.aloLeft;
            lzbasetype.gFmtOpt.BEStyle_Function_FirstParamInNewline = true;
            lzbasetype.gFmtOpt.WSPadding_ParenthesesOfIfStmt = true;

            parser.SqlText.Text = sql;

            parser.PrettyPrint();

            new TSqlTokenizer().TokenizeSql(sql);



        }
    }
}
