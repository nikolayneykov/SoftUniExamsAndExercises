const mongoose = require('mongoose');

let tripSchema = mongoose.Schema({
    origin: {
        type: String,
        required: true
    },
    destination: {
        type: String,
        required: true
    },
    business: {
        type: Number,
        required: true
    },
    economy: {
        type: Number,
        required: true
    },
});

let Trip = mongoose.model('Trip', tripSchema);

module.exports = Trip;
