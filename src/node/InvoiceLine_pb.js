/**
 * @fileoverview
 * @enhanceable
 * @suppress {messageConventions} JS Compiler reports an error if a variable or
 *     field starts with 'MSG_' and isn't a translatable message.
 * @public
 */
// GENERATED CODE -- DO NOT EDIT!

var jspb = require('google-protobuf');
var goog = jspb;
var global = Function('return this')();

goog.exportSymbol('proto.Invoicing.InvoiceLine', null, global);
/**
 * Generated by JsPbCodeGenerator.
 * @param {Array=} opt_data Optional initial data array, typically from a
 * server response, or constructed directly in Javascript. The array is used
 * in place and becomes part of the constructed object. It is not cloned.
 * If no data is provided, the constructed object will be empty, but still
 * valid.
 * @extends {jspb.Message}
 * @constructor
 */
proto.Invoicing.InvoiceLine = function(opt_data) {
  jspb.Message.initialize(this, opt_data, 0, -1, null, null);
};
goog.inherits(proto.Invoicing.InvoiceLine, jspb.Message);
if (goog.DEBUG && !COMPILED) {
  /**
   * @public
   * @override
   */
  proto.Invoicing.InvoiceLine.displayName = 'proto.Invoicing.InvoiceLine';
}



if (jspb.Message.GENERATE_TO_OBJECT) {
/**
 * Creates an object representation of this proto suitable for use in Soy templates.
 * Field names that are reserved in JavaScript and will be renamed to pb_name.
 * To access a reserved field use, foo.pb_<name>, eg, foo.pb_default.
 * For the list of reserved names please see:
 *     com.google.apps.jspb.JsClassTemplate.JS_RESERVED_WORDS.
 * @param {boolean=} opt_includeInstance Whether to include the JSPB instance
 *     for transitional soy proto support: http://goto/soy-param-migration
 * @return {!Object}
 */
proto.Invoicing.InvoiceLine.prototype.toObject = function(opt_includeInstance) {
  return proto.Invoicing.InvoiceLine.toObject(opt_includeInstance, this);
};


/**
 * Static version of the {@see toObject} method.
 * @param {boolean|undefined} includeInstance Whether to include the JSPB
 *     instance for transitional soy proto support:
 *     http://goto/soy-param-migration
 * @param {!proto.Invoicing.InvoiceLine} msg The msg instance to transform.
 * @return {!Object}
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.Invoicing.InvoiceLine.toObject = function(includeInstance, msg) {
  var obj = {
    lineNumber: jspb.Message.getFieldWithDefault(msg, 1, 0),
    productId: jspb.Message.getFieldWithDefault(msg, 2, 0),
    productName: jspb.Message.getFieldWithDefault(msg, 3, ""),
    quantity: jspb.Message.getFieldWithDefault(msg, 4, 0),
    unitPrice: +jspb.Message.getFieldWithDefault(msg, 5, 0.0),
    lineAmount: +jspb.Message.getFieldWithDefault(msg, 6, 0.0)
  };

  if (includeInstance) {
    obj.$jspbMessageInstance = msg;
  }
  return obj;
};
}


/**
 * Deserializes binary data (in protobuf wire format).
 * @param {jspb.ByteSource} bytes The bytes to deserialize.
 * @return {!proto.Invoicing.InvoiceLine}
 */
proto.Invoicing.InvoiceLine.deserializeBinary = function(bytes) {
  var reader = new jspb.BinaryReader(bytes);
  var msg = new proto.Invoicing.InvoiceLine;
  return proto.Invoicing.InvoiceLine.deserializeBinaryFromReader(msg, reader);
};


/**
 * Deserializes binary data (in protobuf wire format) from the
 * given reader into the given message object.
 * @param {!proto.Invoicing.InvoiceLine} msg The message object to deserialize into.
 * @param {!jspb.BinaryReader} reader The BinaryReader to use.
 * @return {!proto.Invoicing.InvoiceLine}
 */
proto.Invoicing.InvoiceLine.deserializeBinaryFromReader = function(msg, reader) {
  while (reader.nextField()) {
    if (reader.isEndGroup()) {
      break;
    }
    var field = reader.getFieldNumber();
    switch (field) {
    case 1:
      var value = /** @type {number} */ (reader.readUint32());
      msg.setLineNumber(value);
      break;
    case 2:
      var value = /** @type {number} */ (reader.readInt32());
      msg.setProductId(value);
      break;
    case 3:
      var value = /** @type {string} */ (reader.readString());
      msg.setProductName(value);
      break;
    case 4:
      var value = /** @type {number} */ (reader.readUint32());
      msg.setQuantity(value);
      break;
    case 5:
      var value = /** @type {number} */ (reader.readFloat());
      msg.setUnitPrice(value);
      break;
    case 6:
      var value = /** @type {number} */ (reader.readFloat());
      msg.setLineAmount(value);
      break;
    default:
      reader.skipField();
      break;
    }
  }
  return msg;
};


/**
 * Serializes the message to binary data (in protobuf wire format).
 * @return {!Uint8Array}
 */
proto.Invoicing.InvoiceLine.prototype.serializeBinary = function() {
  var writer = new jspb.BinaryWriter();
  proto.Invoicing.InvoiceLine.serializeBinaryToWriter(this, writer);
  return writer.getResultBuffer();
};


/**
 * Serializes the given message to binary data (in protobuf wire
 * format), writing to the given BinaryWriter.
 * @param {!proto.Invoicing.InvoiceLine} message
 * @param {!jspb.BinaryWriter} writer
 * @suppress {unusedLocalVariables} f is only used for nested messages
 */
proto.Invoicing.InvoiceLine.serializeBinaryToWriter = function(message, writer) {
  var f = undefined;
  f = message.getLineNumber();
  if (f !== 0) {
    writer.writeUint32(
      1,
      f
    );
  }
  f = message.getProductId();
  if (f !== 0) {
    writer.writeInt32(
      2,
      f
    );
  }
  f = message.getProductName();
  if (f.length > 0) {
    writer.writeString(
      3,
      f
    );
  }
  f = message.getQuantity();
  if (f !== 0) {
    writer.writeUint32(
      4,
      f
    );
  }
  f = message.getUnitPrice();
  if (f !== 0.0) {
    writer.writeFloat(
      5,
      f
    );
  }
  f = message.getLineAmount();
  if (f !== 0.0) {
    writer.writeFloat(
      6,
      f
    );
  }
};


/**
 * optional uint32 line_number = 1;
 * @return {number}
 */
proto.Invoicing.InvoiceLine.prototype.getLineNumber = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 1, 0));
};


/** @param {number} value */
proto.Invoicing.InvoiceLine.prototype.setLineNumber = function(value) {
  jspb.Message.setProto3IntField(this, 1, value);
};


/**
 * optional int32 product_id = 2;
 * @return {number}
 */
proto.Invoicing.InvoiceLine.prototype.getProductId = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 2, 0));
};


/** @param {number} value */
proto.Invoicing.InvoiceLine.prototype.setProductId = function(value) {
  jspb.Message.setProto3IntField(this, 2, value);
};


/**
 * optional string product_name = 3;
 * @return {string}
 */
proto.Invoicing.InvoiceLine.prototype.getProductName = function() {
  return /** @type {string} */ (jspb.Message.getFieldWithDefault(this, 3, ""));
};


/** @param {string} value */
proto.Invoicing.InvoiceLine.prototype.setProductName = function(value) {
  jspb.Message.setProto3StringField(this, 3, value);
};


/**
 * optional uint32 quantity = 4;
 * @return {number}
 */
proto.Invoicing.InvoiceLine.prototype.getQuantity = function() {
  return /** @type {number} */ (jspb.Message.getFieldWithDefault(this, 4, 0));
};


/** @param {number} value */
proto.Invoicing.InvoiceLine.prototype.setQuantity = function(value) {
  jspb.Message.setProto3IntField(this, 4, value);
};


/**
 * optional float unit_price = 5;
 * @return {number}
 */
proto.Invoicing.InvoiceLine.prototype.getUnitPrice = function() {
  return /** @type {number} */ (+jspb.Message.getFieldWithDefault(this, 5, 0.0));
};


/** @param {number} value */
proto.Invoicing.InvoiceLine.prototype.setUnitPrice = function(value) {
  jspb.Message.setProto3FloatField(this, 5, value);
};


/**
 * optional float line_amount = 6;
 * @return {number}
 */
proto.Invoicing.InvoiceLine.prototype.getLineAmount = function() {
  return /** @type {number} */ (+jspb.Message.getFieldWithDefault(this, 6, 0.0));
};


/** @param {number} value */
proto.Invoicing.InvoiceLine.prototype.setLineAmount = function(value) {
  jspb.Message.setProto3FloatField(this, 6, value);
};


goog.object.extend(exports, proto.Invoicing);
