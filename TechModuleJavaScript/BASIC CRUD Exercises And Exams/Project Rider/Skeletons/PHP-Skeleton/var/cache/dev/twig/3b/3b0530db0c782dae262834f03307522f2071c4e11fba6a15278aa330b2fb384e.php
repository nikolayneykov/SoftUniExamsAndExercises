<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_f32ad73c9bc804e7d7685ce925e27ce9c7daa98efc0b9a8c89227d7076a75563 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_924c75f9f46c915fe68ea2fade701c80eeff1a950f5f7004dba24b2ea973cc48 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_924c75f9f46c915fe68ea2fade701c80eeff1a950f5f7004dba24b2ea973cc48->enter($__internal_924c75f9f46c915fe68ea2fade701c80eeff1a950f5f7004dba24b2ea973cc48_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_100afb2bdc4e5a3d382879d4e726995bc91de7a76c90bbc1808559ac10dc67b9 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_100afb2bdc4e5a3d382879d4e726995bc91de7a76c90bbc1808559ac10dc67b9->enter($__internal_100afb2bdc4e5a3d382879d4e726995bc91de7a76c90bbc1808559ac10dc67b9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_924c75f9f46c915fe68ea2fade701c80eeff1a950f5f7004dba24b2ea973cc48->leave($__internal_924c75f9f46c915fe68ea2fade701c80eeff1a950f5f7004dba24b2ea973cc48_prof);

        
        $__internal_100afb2bdc4e5a3d382879d4e726995bc91de7a76c90bbc1808559ac10dc67b9->leave($__internal_100afb2bdc4e5a3d382879d4e726995bc91de7a76c90bbc1808559ac10dc67b9_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_8863efd763259ee85f0d187209b1a3203445b9e7932c6b1ec4b7d782c62ccdca = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8863efd763259ee85f0d187209b1a3203445b9e7932c6b1ec4b7d782c62ccdca->enter($__internal_8863efd763259ee85f0d187209b1a3203445b9e7932c6b1ec4b7d782c62ccdca_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_015273f8f724f1b11d1f3de6d693bf124758d52c02c673de60f9e087df120a3e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_015273f8f724f1b11d1f3de6d693bf124758d52c02c673de60f9e087df120a3e->enter($__internal_015273f8f724f1b11d1f3de6d693bf124758d52c02c673de60f9e087df120a3e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_015273f8f724f1b11d1f3de6d693bf124758d52c02c673de60f9e087df120a3e->leave($__internal_015273f8f724f1b11d1f3de6d693bf124758d52c02c673de60f9e087df120a3e_prof);

        
        $__internal_8863efd763259ee85f0d187209b1a3203445b9e7932c6b1ec4b7d782c62ccdca->leave($__internal_8863efd763259ee85f0d187209b1a3203445b9e7932c6b1ec4b7d782c62ccdca_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_140d4c36d100bd9527dbbbf6ecb165e96bd4615c4f29a59c81cad6723dfd02e5 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_140d4c36d100bd9527dbbbf6ecb165e96bd4615c4f29a59c81cad6723dfd02e5->enter($__internal_140d4c36d100bd9527dbbbf6ecb165e96bd4615c4f29a59c81cad6723dfd02e5_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_acd732435e12013f0142f099f6ac317893f0252dbc19c7728e4c18bb67773222 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_acd732435e12013f0142f099f6ac317893f0252dbc19c7728e4c18bb67773222->enter($__internal_acd732435e12013f0142f099f6ac317893f0252dbc19c7728e4c18bb67773222_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_acd732435e12013f0142f099f6ac317893f0252dbc19c7728e4c18bb67773222->leave($__internal_acd732435e12013f0142f099f6ac317893f0252dbc19c7728e4c18bb67773222_prof);

        
        $__internal_140d4c36d100bd9527dbbbf6ecb165e96bd4615c4f29a59c81cad6723dfd02e5->leave($__internal_140d4c36d100bd9527dbbbf6ecb165e96bd4615c4f29a59c81cad6723dfd02e5_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_de94bac41dff4b51f0ef260670f6cbe99839ce365a63e4eb5bb68f64413d75df = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_de94bac41dff4b51f0ef260670f6cbe99839ce365a63e4eb5bb68f64413d75df->enter($__internal_de94bac41dff4b51f0ef260670f6cbe99839ce365a63e4eb5bb68f64413d75df_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_8c6ee04ecb631af80e9a3c6a73edce61983a2b0e658b508e1c7eb7b799b1553b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8c6ee04ecb631af80e9a3c6a73edce61983a2b0e658b508e1c7eb7b799b1553b->enter($__internal_8c6ee04ecb631af80e9a3c6a73edce61983a2b0e658b508e1c7eb7b799b1553b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_8c6ee04ecb631af80e9a3c6a73edce61983a2b0e658b508e1c7eb7b799b1553b->leave($__internal_8c6ee04ecb631af80e9a3c6a73edce61983a2b0e658b508e1c7eb7b799b1553b_prof);

        
        $__internal_de94bac41dff4b51f0ef260670f6cbe99839ce365a63e4eb5bb68f64413d75df->leave($__internal_de94bac41dff4b51f0ef260670f6cbe99839ce365a63e4eb5bb68f64413d75df_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
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

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
", "@WebProfiler/Collector/exception.html.twig", "C:\\Users\\Ivo\\Desktop\\Soft-Tech-Exam-03\\Solutions\\PHP Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}
