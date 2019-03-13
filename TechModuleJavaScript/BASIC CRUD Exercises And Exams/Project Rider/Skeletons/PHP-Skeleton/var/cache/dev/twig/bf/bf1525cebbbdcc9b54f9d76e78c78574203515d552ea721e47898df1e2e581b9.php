<?php

/* project/create.html.twig */
class __TwigTemplate_2a1b5d707aa72104692b6ffa1a05c4fb1e74d1bf350d67ef9d0e176233c33cfd extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", "project/create.html.twig", 1);
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
        $__internal_2c95bc810dd224dc08389e130d03e7ffb231490e9eb650ba8336781eca57cc81 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2c95bc810dd224dc08389e130d03e7ffb231490e9eb650ba8336781eca57cc81->enter($__internal_2c95bc810dd224dc08389e130d03e7ffb231490e9eb650ba8336781eca57cc81_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/create.html.twig"));

        $__internal_6ec203cf99e9f03b962424ebb55e05130a3676654061d267a25c7089dc4ab023 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6ec203cf99e9f03b962424ebb55e05130a3676654061d267a25c7089dc4ab023->enter($__internal_6ec203cf99e9f03b962424ebb55e05130a3676654061d267a25c7089dc4ab023_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "project/create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_2c95bc810dd224dc08389e130d03e7ffb231490e9eb650ba8336781eca57cc81->leave($__internal_2c95bc810dd224dc08389e130d03e7ffb231490e9eb650ba8336781eca57cc81_prof);

        
        $__internal_6ec203cf99e9f03b962424ebb55e05130a3676654061d267a25c7089dc4ab023->leave($__internal_6ec203cf99e9f03b962424ebb55e05130a3676654061d267a25c7089dc4ab023_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_108ff1e01a50a64b53c3d18fe4dc5f82d908cd01bf499c5ec6ce99ff225700b8 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_108ff1e01a50a64b53c3d18fe4dc5f82d908cd01bf499c5ec6ce99ff225700b8->enter($__internal_108ff1e01a50a64b53c3d18fe4dc5f82d908cd01bf499c5ec6ce99ff225700b8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_46a7515ce3658ff2a828365e98d2cac6632c7e8349723201f508cdcda5a56f67 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_46a7515ce3658ff2a828365e98d2cac6632c7e8349723201f508cdcda5a56f67->enter($__internal_46a7515ce3658ff2a828365e98d2cac6632c7e8349723201f508cdcda5a56f67_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_46a7515ce3658ff2a828365e98d2cac6632c7e8349723201f508cdcda5a56f67->leave($__internal_46a7515ce3658ff2a828365e98d2cac6632c7e8349723201f508cdcda5a56f67_prof);

        
        $__internal_108ff1e01a50a64b53c3d18fe4dc5f82d908cd01bf499c5ec6ce99ff225700b8->leave($__internal_108ff1e01a50a64b53c3d18fe4dc5f82d908cd01bf499c5ec6ce99ff225700b8_prof);

    }

    public function getTemplateName()
    {
        return "project/create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 26,  49 => 4,  40 => 3,  11 => 1,);
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
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", "project/create.html.twig", "C:\\Users\\Ivo\\Desktop\\Soft-Tech-Exam-03\\Solutions\\PHP Skeleton\\app\\Resources\\views\\project\\create.html.twig");
    }
}
