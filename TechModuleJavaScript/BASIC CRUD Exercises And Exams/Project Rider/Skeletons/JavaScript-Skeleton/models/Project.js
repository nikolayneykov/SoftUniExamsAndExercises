const mongoose = require('mongoose');

let projectSchema = mongoose.Schema({
    title: {
        type: String,
        required: true
    },
    description: {
        type: String,
        required: true
    },
    budget: {
        type: Number,
        required: true
    },
});

let Project = mongoose.model('Project', projectSchema);

module.exports = Project;
