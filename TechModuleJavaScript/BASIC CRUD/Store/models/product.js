const mongoose = require('mongoose');

const productSchema = new mongoose.Schema({
    name: {
        type: mongoose.Schema.Types.String,
        required: true
    },
    price: {
        type: mongoose.Schema.Types.Number
    }
});

const Product = mongoose.model('Product', productSchema);

module.exports = Product;