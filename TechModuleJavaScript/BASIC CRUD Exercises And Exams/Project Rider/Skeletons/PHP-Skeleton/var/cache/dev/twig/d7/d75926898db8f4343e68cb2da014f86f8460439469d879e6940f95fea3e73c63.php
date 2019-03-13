<?php

/* project/edit.html.twig */
class __TwigTemplate_f87bd5160ece83d12b7f4659cc2b9f9000fb392b743a79100d9e32743f557ed4 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/edit.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_273c373b469b0c187116736c8117b394239e33f3331c2f20cfc35e9ff8f62063 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_273c373b469b0c187116736c8117b394239e33f3331c2f20cfc35e9ff8f62063->enter($__internal_273c373b469b0c187116736c8117b394239e33f3331c2f20cfc35e9ff8f62063_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/edit.html.twig"));

        $__internal_f96bfddb8d9de17ba99effd9edf4cc2bc040e4c55ad4bf0f44b664772ed348c0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f96bfddb8d9de17ba99effd9edf4cc2bc040e4c55ad4bf0f44b664772ed348c0->enter($__internal_f96bfddb8d9de17ba99effd9edf4cc2bc040e4c55ad4bf0f44b664772ed348c0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/edit.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_273c373b469b0c187116736c8117b394239e33f3331c2f20cfc35e9ff8f62063->leave($__internal_273c373b469b0c187116736c8117b394239e33f3331c2f20cfc35e9ff8f62063_prof);

        
        $__internal_f96bfddb8d9de17ba99effd9edf4cc2bc040e4c55ad4bf0f44b664772ed348c0->leave($__internal_f96bfddb8d9de17ba99effd9edf4cc2bc040e4c55ad4bf0f44b664772ed348c0_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_c8852228f880cfe1ba26018a616ebf963c946b29b714ba2c59b4538ee42d649d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c8852228f880cfe1ba26018a616ebf963c946b29b714ba2c59b4538ee42d649d->enter($__internal_c8852228f880cfe1ba26018a616ebf963c946b29b714ba2c59b4538ee42d649d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_86f20af403b49b325843571ae90bcfb5b2dc6779408ca04029beebe2e83ea96f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_86f20af403b49b325843571ae90bcfb5b2dc6779408ca04029beebe2e83ea96f->enter($__internal_86f20af403b49b325843571ae90bcfb5b2dc6779408ca04029beebe2e83ea96f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "title", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">";
        // line 15
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "description", array()), "html", null, true);
        echo "</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"";
        // line 19
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "budget", array()), "html", null, true);
        echo "\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_86f20af403b49b325843571ae90bcfb5b2dc6779408ca04029beebe2e83ea96f->leave($__internal_86f20af403b49b325843571ae90bcfb5b2dc6779408ca04029beebe2e83ea96f_prof);

        
        $__internal_c8852228f880cfe1ba26018a616ebf963c946b29b714ba2c59b4538ee42d649d->leave($__internal_c8852228f880cfe1ba26018a616ebf963c946b29b714ba2c59b4538ee42d649d_prof);

    }

    public function getTemplateName()
    {
        return "project/edit.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  82 => 26,  72 => 19,  65 => 15,  58 => 11,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"{{ project.title }}\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\">{{ project.description }}</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"{{ project.budget }}\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Edit Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}

", "project/edit.html.twig", "C:\\Users\\Ivo\\Desktop\\Soft-Tech-Exam-03\\Solutions\\PHP Skeleton\\app\\Resources\\views\\project\\edit.html.twig");
    }
}
