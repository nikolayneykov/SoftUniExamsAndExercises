const mongoose = require('mongoose');

const Schema = mongoose.Schema;

const taskSchema = new Schema({
    title: {
        type: String,
        required: true
    },
    status: {
        type: String,
        required: true,
        enum: ['Open', 'In Progress', 'Finished']
    }
});

const Task = mongoose.model('Task', taskSchema);

module.exports = Task;