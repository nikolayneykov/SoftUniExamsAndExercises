<?php

/* base.html.twig */
class __TwigTemplate_93e2499d03c6402ea1e3906495568257ed0120721f7f5badb0e11600e82927c5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_13053020340688ee4a6dad8b7dc940787c34cf847a41e097f037b2930e872d74 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_13053020340688ee4a6dad8b7dc940787c34cf847a41e097f037b2930e872d74->enter($__internal_13053020340688ee4a6dad8b7dc940787c34cf847a41e097f037b2930e872d74_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_87a308054196e48d3f1d837218242f477e61568cf4174e9ec81a21fdb32cded5 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_87a308054196e48d3f1d837218242f477e61568cf4174e9ec81a21fdb32cded5->enter($__internal_87a308054196e48d3f1d837218242f477e61568cf4174e9ec81a21fdb32cded5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>";
        // line 10
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 11
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 20
        $this->displayBlock('body', $context, $blocks);
        // line 23
        echo "</body>
</html>
";
        
        $__internal_13053020340688ee4a6dad8b7dc940787c34cf847a41e097f037b2930e872d74->leave($__internal_13053020340688ee4a6dad8b7dc940787c34cf847a41e097f037b2930e872d74_prof);

        
        $__internal_87a308054196e48d3f1d837218242f477e61568cf4174e9ec81a21fdb32cded5->leave($__internal_87a308054196e48d3f1d837218242f477e61568cf4174e9ec81a21fdb32cded5_prof);

    }

    // line 10
    public function block_title($context, array $blocks = array())
    {
        $__internal_3184e1173295b77c880db3766ae0b683982c62d553b8326e0f02a1664d1bf91a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3184e1173295b77c880db3766ae0b683982c62d553b8326e0f02a1664d1bf91a->enter($__internal_3184e1173295b77c880db3766ae0b683982c62d553b8326e0f02a1664d1bf91a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_b46b1a16608c8bb1c4d56c393a9bc066dfe5831f19b3811d5f0b0190752fea67 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b46b1a16608c8bb1c4d56c393a9bc066dfe5831f19b3811d5f0b0190752fea67->enter($__internal_b46b1a16608c8bb1c4d56c393a9bc066dfe5831f19b3811d5f0b0190752fea67_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Project Rider";
        
        $__internal_b46b1a16608c8bb1c4d56c393a9bc066dfe5831f19b3811d5f0b0190752fea67->leave($__internal_b46b1a16608c8bb1c4d56c393a9bc066dfe5831f19b3811d5f0b0190752fea67_prof);

        
        $__internal_3184e1173295b77c880db3766ae0b683982c62d553b8326e0f02a1664d1bf91a->leave($__internal_3184e1173295b77c880db3766ae0b683982c62d553b8326e0f02a1664d1bf91a_prof);

    }

    // line 11
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_38f73ec484dae8eae98d316f28ad20fcf15c4cd120a141005934aa239315232b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_38f73ec484dae8eae98d316f28ad20fcf15c4cd120a141005934aa239315232b->enter($__internal_38f73ec484dae8eae98d316f28ad20fcf15c4cd120a141005934aa239315232b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_a3cd32ca451de8567c721f0dc0c2b089cf2874562b5bc872da187be5a268a5ff = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a3cd32ca451de8567c721f0dc0c2b089cf2874562b5bc872da187be5a268a5ff->enter($__internal_a3cd32ca451de8567c721f0dc0c2b089cf2874562b5bc872da187be5a268a5ff_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 12
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/reset.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/create-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_a3cd32ca451de8567c721f0dc0c2b089cf2874562b5bc872da187be5a268a5ff->leave($__internal_a3cd32ca451de8567c721f0dc0c2b089cf2874562b5bc872da187be5a268a5ff_prof);

        
        $__internal_38f73ec484dae8eae98d316f28ad20fcf15c4cd120a141005934aa239315232b->leave($__internal_38f73ec484dae8eae98d316f28ad20fcf15c4cd120a141005934aa239315232b_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_85d5acac4f3f9db0d7adc36a0a552d6dec9e3683127cd63c17d0b436ae480a1c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_85d5acac4f3f9db0d7adc36a0a552d6dec9e3683127cd63c17d0b436ae480a1c->enter($__internal_85d5acac4f3f9db0d7adc36a0a552d6dec9e3683127cd63c17d0b436ae480a1c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_cb083b8594d9084a6dbc367453892b214ea5aaf97b063e252aecd658ea89d4d7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cb083b8594d9084a6dbc367453892b214ea5aaf97b063e252aecd658ea89d4d7->enter($__internal_cb083b8594d9084a6dbc367453892b214ea5aaf97b063e252aecd658ea89d4d7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_cb083b8594d9084a6dbc367453892b214ea5aaf97b063e252aecd658ea89d4d7->leave($__internal_cb083b8594d9084a6dbc367453892b214ea5aaf97b063e252aecd658ea89d4d7_prof);

        
        $__internal_85d5acac4f3f9db0d7adc36a0a552d6dec9e3683127cd63c17d0b436ae480a1c->leave($__internal_85d5acac4f3f9db0d7adc36a0a552d6dec9e3683127cd63c17d0b436ae480a1c_prof);

    }

    // line 20
    public function block_body($context, array $blocks = array())
    {
        $__internal_c05446e26cdef25e09ba81c3ce7329c0fca4686b4b346975d32b574f0c68017a = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c05446e26cdef25e09ba81c3ce7329c0fca4686b4b346975d32b574f0c68017a->enter($__internal_c05446e26cdef25e09ba81c3ce7329c0fca4686b4b346975d32b574f0c68017a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_7fd8899424e6e9ceb95ef1298ad95818334abe37907615aa60b47243f390f4a6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7fd8899424e6e9ceb95ef1298ad95818334abe37907615aa60b47243f390f4a6->enter($__internal_7fd8899424e6e9ceb95ef1298ad95818334abe37907615aa60b47243f390f4a6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 21
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_7fd8899424e6e9ceb95ef1298ad95818334abe37907615aa60b47243f390f4a6->leave($__internal_7fd8899424e6e9ceb95ef1298ad95818334abe37907615aa60b47243f390f4a6_prof);

        
        $__internal_c05446e26cdef25e09ba81c3ce7329c0fca4686b4b346975d32b574f0c68017a->leave($__internal_c05446e26cdef25e09ba81c3ce7329c0fca4686b4b346975d32b574f0c68017a_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_a7bd788a93b08cf8920983007977fea85e688668269850a50549000c31b7fd1c = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_a7bd788a93b08cf8920983007977fea85e688668269850a50549000c31b7fd1c->enter($__internal_a7bd788a93b08cf8920983007977fea85e688668269850a50549000c31b7fd1c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_8081b90967795c6a1448e169be4ebfce64588f9debc810b244799792573d87d0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8081b90967795c6a1448e169be4ebfce64588f9debc810b244799792573d87d0->enter($__internal_8081b90967795c6a1448e169be4ebfce64588f9debc810b244799792573d87d0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_8081b90967795c6a1448e169be4ebfce64588f9debc810b244799792573d87d0->leave($__internal_8081b90967795c6a1448e169be4ebfce64588f9debc810b244799792573d87d0_prof);

        
        $__internal_a7bd788a93b08cf8920983007977fea85e688668269850a50549000c31b7fd1c->leave($__internal_a7bd788a93b08cf8920983007977fea85e688668269850a50549000c31b7fd1c_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  141 => 21,  132 => 20,  115 => 19,  103 => 14,  99 => 13,  94 => 12,  85 => 11,  67 => 10,  55 => 23,  53 => 20,  49 => 19,  42 => 16,  40 => 11,  36 => 10,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>{% block title %}Project Rider{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/reset.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/create-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "C:\\Users\\Ivo\\Desktop\\Soft-Tech-Exam-03\\Solutions\\PHP Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}
