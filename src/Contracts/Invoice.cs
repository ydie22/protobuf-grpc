// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Invoice.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Invoicing {

  /// <summary>Holder for reflection information generated from Invoice.proto</summary>
  public static partial class InvoiceReflection {

    #region Descriptor
    /// <summary>File descriptor for Invoice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InvoiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1JbnZvaWNlLnByb3RvEglJbnZvaWNpbmcaH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8aEUludm9pY2VMaW5lLnByb3RvIvQBCgdJbnZvaWNl",
            "EhYKDmludm9pY2VfbnVtYmVyGAEgASgJEhMKC2N1c3RvbWVyX2lkGAIgASgF",
            "EhUKDWN1c3RvbWVyX25hbWUYAyABKAkSMAoMaW52b2ljZV9kYXRlGAQgASgL",
            "MhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIUCgx0b3RhbF9hbW91bnQY",
            "BSABKAISNgoRcGF5bWVudF9jb25kaXRpb24YBiABKA4yGy5JbnZvaWNpbmcu",
            "UGF5bWVudENvbmRpdGlvbhIlCgVMaW5lcxgHIAMoCzIWLkludm9pY2luZy5J",
            "bnZvaWNlTGluZSpPChBQYXltZW50Q29uZGl0aW9uEggKBENBU0gQABIQCgxF",
            "TkRfT0ZfTU9OVEgQARIOCgpTSVhUWV9EQVlTEAISDwoLTklORVRZX0RBWVMQ",
            "A0IMqgIJSW52b2ljaW5nYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Invoicing.InvoiceLineReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Invoicing.PaymentCondition), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Invoicing.Invoice), global::Invoicing.Invoice.Parser, new[]{ "InvoiceNumber", "CustomerId", "CustomerName", "InvoiceDate", "TotalAmount", "PaymentCondition", "Lines" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum PaymentCondition {
    [pbr::OriginalName("CASH")] Cash = 0,
    [pbr::OriginalName("END_OF_MONTH")] EndOfMonth = 1,
    [pbr::OriginalName("SIXTY_DAYS")] SixtyDays = 2,
    [pbr::OriginalName("NINETY_DAYS")] NinetyDays = 3,
  }

  #endregion

  #region Messages
  public sealed partial class Invoice : pb::IMessage<Invoice> {
    private static readonly pb::MessageParser<Invoice> _parser = new pb::MessageParser<Invoice>(() => new Invoice());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Invoice> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Invoicing.InvoiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Invoice() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Invoice(Invoice other) : this() {
      invoiceNumber_ = other.invoiceNumber_;
      customerId_ = other.customerId_;
      customerName_ = other.customerName_;
      invoiceDate_ = other.invoiceDate_ != null ? other.invoiceDate_.Clone() : null;
      totalAmount_ = other.totalAmount_;
      paymentCondition_ = other.paymentCondition_;
      lines_ = other.lines_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Invoice Clone() {
      return new Invoice(this);
    }

    /// <summary>Field number for the "invoice_number" field.</summary>
    public const int InvoiceNumberFieldNumber = 1;
    private string invoiceNumber_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InvoiceNumber {
      get { return invoiceNumber_; }
      set {
        invoiceNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 2;
    private int customerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CustomerId {
      get { return customerId_; }
      set {
        customerId_ = value;
      }
    }

    /// <summary>Field number for the "customer_name" field.</summary>
    public const int CustomerNameFieldNumber = 3;
    private string customerName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerName {
      get { return customerName_; }
      set {
        customerName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "invoice_date" field.</summary>
    public const int InvoiceDateFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp invoiceDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp InvoiceDate {
      get { return invoiceDate_; }
      set {
        invoiceDate_ = value;
      }
    }

    /// <summary>Field number for the "total_amount" field.</summary>
    public const int TotalAmountFieldNumber = 5;
    private float totalAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float TotalAmount {
      get { return totalAmount_; }
      set {
        totalAmount_ = value;
      }
    }

    /// <summary>Field number for the "payment_condition" field.</summary>
    public const int PaymentConditionFieldNumber = 6;
    private global::Invoicing.PaymentCondition paymentCondition_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Invoicing.PaymentCondition PaymentCondition {
      get { return paymentCondition_; }
      set {
        paymentCondition_ = value;
      }
    }

    /// <summary>Field number for the "Lines" field.</summary>
    public const int LinesFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Invoicing.InvoiceLine> _repeated_lines_codec
        = pb::FieldCodec.ForMessage(58, global::Invoicing.InvoiceLine.Parser);
    private readonly pbc::RepeatedField<global::Invoicing.InvoiceLine> lines_ = new pbc::RepeatedField<global::Invoicing.InvoiceLine>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Invoicing.InvoiceLine> Lines {
      get { return lines_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Invoice);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Invoice other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InvoiceNumber != other.InvoiceNumber) return false;
      if (CustomerId != other.CustomerId) return false;
      if (CustomerName != other.CustomerName) return false;
      if (!object.Equals(InvoiceDate, other.InvoiceDate)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TotalAmount, other.TotalAmount)) return false;
      if (PaymentCondition != other.PaymentCondition) return false;
      if(!lines_.Equals(other.lines_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (InvoiceNumber.Length != 0) hash ^= InvoiceNumber.GetHashCode();
      if (CustomerId != 0) hash ^= CustomerId.GetHashCode();
      if (CustomerName.Length != 0) hash ^= CustomerName.GetHashCode();
      if (invoiceDate_ != null) hash ^= InvoiceDate.GetHashCode();
      if (TotalAmount != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TotalAmount);
      if (PaymentCondition != 0) hash ^= PaymentCondition.GetHashCode();
      hash ^= lines_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (InvoiceNumber.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(InvoiceNumber);
      }
      if (CustomerId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CustomerId);
      }
      if (CustomerName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CustomerName);
      }
      if (invoiceDate_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(InvoiceDate);
      }
      if (TotalAmount != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(TotalAmount);
      }
      if (PaymentCondition != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) PaymentCondition);
      }
      lines_.WriteTo(output, _repeated_lines_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (InvoiceNumber.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InvoiceNumber);
      }
      if (CustomerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CustomerId);
      }
      if (CustomerName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerName);
      }
      if (invoiceDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(InvoiceDate);
      }
      if (TotalAmount != 0F) {
        size += 1 + 4;
      }
      if (PaymentCondition != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PaymentCondition);
      }
      size += lines_.CalculateSize(_repeated_lines_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Invoice other) {
      if (other == null) {
        return;
      }
      if (other.InvoiceNumber.Length != 0) {
        InvoiceNumber = other.InvoiceNumber;
      }
      if (other.CustomerId != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.CustomerName.Length != 0) {
        CustomerName = other.CustomerName;
      }
      if (other.invoiceDate_ != null) {
        if (invoiceDate_ == null) {
          InvoiceDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        InvoiceDate.MergeFrom(other.InvoiceDate);
      }
      if (other.TotalAmount != 0F) {
        TotalAmount = other.TotalAmount;
      }
      if (other.PaymentCondition != 0) {
        PaymentCondition = other.PaymentCondition;
      }
      lines_.Add(other.lines_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            InvoiceNumber = input.ReadString();
            break;
          }
          case 16: {
            CustomerId = input.ReadInt32();
            break;
          }
          case 26: {
            CustomerName = input.ReadString();
            break;
          }
          case 34: {
            if (invoiceDate_ == null) {
              InvoiceDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(InvoiceDate);
            break;
          }
          case 45: {
            TotalAmount = input.ReadFloat();
            break;
          }
          case 48: {
            PaymentCondition = (global::Invoicing.PaymentCondition) input.ReadEnum();
            break;
          }
          case 58: {
            lines_.AddEntriesFrom(input, _repeated_lines_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
