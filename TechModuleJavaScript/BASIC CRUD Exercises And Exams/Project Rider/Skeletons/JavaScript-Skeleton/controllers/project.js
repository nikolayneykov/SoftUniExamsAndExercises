const Project = require('../models/Project');

module.exports = {
    index: (req, res) => {
        Project.find({}).then(function (projects) {
            res.render('../views/project/index', { projects });
        });
    },
    createGet: (req, res) => {
        res.render('../views/project/create');
    },
    createPost: (req, res) => {
        let project = req.body;
        Project.create(project).then(function () {
            res.redirect('/');
        });
    },
    editGet: (req, res) => {
        let id = req.params.id;
        Project.findById(id).then(function (project) {
            let title = project.title;
            let description = project.description;
            let budget = project.budget;
            res.render('../views/project/edit', { title, description, budget });
        });
    },
    editPost: (req, res) => {
        let id = req.params.id;
        let newProject = req.body;
        Project.findByIdAndUpdate(id, newProject).then(function () {
            res.redirect('/');
        });
    },
    deleteGet: (req, res) => {
        let id = req.params.id;
        Project.findById(id).then(function (project) {
            let title = project.title;
            let description = project.description;
            let budget = project.budget;
            res.render('../views/project/delete', { title, description, budget });
        });
    },
    deletePost: (req, res) => {
        let id = req.params.id;
        Project.findByIdAndRemove(id).then(function () {
            res.redirect('/');
        });
    }
};