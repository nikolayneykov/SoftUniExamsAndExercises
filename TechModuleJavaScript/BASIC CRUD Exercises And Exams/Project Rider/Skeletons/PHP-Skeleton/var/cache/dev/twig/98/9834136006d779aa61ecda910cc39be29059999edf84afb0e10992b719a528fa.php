<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_09886c37796d81d574b2448cf2a22ea32da8dad546b69f22c376ce19a869ce97 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_4e7a40e24bc39f11d4e69b581a9671c0afb2b350b3321f6ca7cd1732c9fa26e5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_4e7a40e24bc39f11d4e69b581a9671c0afb2b350b3321f6ca7cd1732c9fa26e5->enter($__internal_4e7a40e24bc39f11d4e69b581a9671c0afb2b350b3321f6ca7cd1732c9fa26e5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_18c5085b7f69e5f2e516d004550c06e7434a0a7dcaa37a923ad08a43d743dc96 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_18c5085b7f69e5f2e516d004550c06e7434a0a7dcaa37a923ad08a43d743dc96->enter($__internal_18c5085b7f69e5f2e516d004550c06e7434a0a7dcaa37a923ad08a43d743dc96_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_4e7a40e24bc39f11d4e69b581a9671c0afb2b350b3321f6ca7cd1732c9fa26e5->leave($__internal_4e7a40e24bc39f11d4e69b581a9671c0afb2b350b3321f6ca7cd1732c9fa26e5_prof);

        
        $__internal_18c5085b7f69e5f2e516d004550c06e7434a0a7dcaa37a923ad08a43d743dc96->leave($__internal_18c5085b7f69e5f2e516d004550c06e7434a0a7dcaa37a923ad08a43d743dc96_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_ff7c9770c3c90b2ffbc530513d401b160f58ff01dda8efaee1e1cba5b790683d = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ff7c9770c3c90b2ffbc530513d401b160f58ff01dda8efaee1e1cba5b790683d->enter($__internal_ff7c9770c3c90b2ffbc530513d401b160f58ff01dda8efaee1e1cba5b790683d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_aa2d2be20a8078a1ce5dc3a07fe9a5c937be0f1a92a81462a3870af81397d741 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_aa2d2be20a8078a1ce5dc3a07fe9a5c937be0f1a92a81462a3870af81397d741->enter($__internal_aa2d2be20a8078a1ce5dc3a07fe9a5c937be0f1a92a81462a3870af81397d741_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_aa2d2be20a8078a1ce5dc3a07fe9a5c937be0f1a92a81462a3870af81397d741->leave($__internal_aa2d2be20a8078a1ce5dc3a07fe9a5c937be0f1a92a81462a3870af81397d741_prof);

        
        $__internal_ff7c9770c3c90b2ffbc530513d401b160f58ff01dda8efaee1e1cba5b790683d->leave($__internal_ff7c9770c3c90b2ffbc530513d401b160f58ff01dda8efaee1e1cba5b790683d_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_39def031c72f0a17f83355aceded17f073f05e81323f9e39e9d5d1cbcd78aca6 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_39def031c72f0a17f83355aceded17f073f05e81323f9e39e9d5d1cbcd78aca6->enter($__internal_39def031c72f0a17f83355aceded17f073f05e81323f9e39e9d5d1cbcd78aca6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_616bc6f368d49813a5b3a8f9e2b08a282815ce3728c26ac0ea381cd030dc9be9 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_616bc6f368d49813a5b3a8f9e2b08a282815ce3728c26ac0ea381cd030dc9be9->enter($__internal_616bc6f368d49813a5b3a8f9e2b08a282815ce3728c26ac0ea381cd030dc9be9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_616bc6f368d49813a5b3a8f9e2b08a282815ce3728c26ac0ea381cd030dc9be9->leave($__internal_616bc6f368d49813a5b3a8f9e2b08a282815ce3728c26ac0ea381cd030dc9be9_prof);

        
        $__internal_39def031c72f0a17f83355aceded17f073f05e81323f9e39e9d5d1cbcd78aca6->leave($__internal_39def031c72f0a17f83355aceded17f073f05e81323f9e39e9d5d1cbcd78aca6_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_17bc3cdd755c2934f41b22d780232c2b3b39a0c993cd15bcc4e5f1d1d9e41ae0 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_17bc3cdd755c2934f41b22d780232c2b3b39a0c993cd15bcc4e5f1d1d9e41ae0->enter($__internal_17bc3cdd755c2934f41b22d780232c2b3b39a0c993cd15bcc4e5f1d1d9e41ae0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_a66c991423218d4d2164db0a1100c10e8bb78c4801a30b701d4ac5ded94a032a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a66c991423218d4d2164db0a1100c10e8bb78c4801a30b701d4ac5ded94a032a->enter($__internal_a66c991423218d4d2164db0a1100c10e8bb78c4801a30b701d4ac5ded94a032a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_a66c991423218d4d2164db0a1100c10e8bb78c4801a30b701d4ac5ded94a032a->leave($__internal_a66c991423218d4d2164db0a1100c10e8bb78c4801a30b701d4ac5ded94a032a_prof);

        
        $__internal_17bc3cdd755c2934f41b22d780232c2b3b39a0c993cd15bcc4e5f1d1d9e41ae0->leave($__internal_17bc3cdd755c2934f41b22d780232c2b3b39a0c993cd15bcc4e5f1d1d9e41ae0_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
", "@WebProfiler/Collector/router.html.twig", "C:\\Users\\Ivo\\Desktop\\Soft-Tech-Exam-03\\Solutions\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}
