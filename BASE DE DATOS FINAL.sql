PGDMP  !                    |         	   db_optica    17.0    17.0 4    E           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            F           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            G           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            H           1262    41478 	   db_optica    DATABASE     |   CREATE DATABASE db_optica WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Spain.1252';
    DROP DATABASE db_optica;
                     postgres    false            �            1259    41648 
   categorias    TABLE     �   CREATE TABLE public.categorias (
    id_categoria integer NOT NULL,
    nombre_categoria character varying(100) NOT NULL,
    descripcion character varying(255)
);
    DROP TABLE public.categorias;
       public         heap r       postgres    false            �            1259    41643    clasificacion    TABLE     �   CREATE TABLE public.clasificacion (
    id_clasificacion integer NOT NULL,
    nombre_clasificacion character varying(100) NOT NULL
);
 !   DROP TABLE public.clasificacion;
       public         heap r       postgres    false            �            1259    41687    controladores    TABLE     �   CREATE TABLE public.controladores (
    id_controlador integer NOT NULL,
    nombre_controlador character varying(100) NOT NULL,
    descripcion character varying(255)
);
 !   DROP TABLE public.controladores;
       public         heap r       postgres    false            �            1259    41677    inventario_local    TABLE     �   CREATE TABLE public.inventario_local (
    id_inventario integer NOT NULL,
    id_producto integer NOT NULL,
    id_local integer NOT NULL,
    cantidad integer,
    fecha_ultima_actualizacion date
);
 $   DROP TABLE public.inventario_local;
       public         heap r       postgres    false            �            1259    41672    locales    TABLE     �   CREATE TABLE public.locales (
    id_local integer NOT NULL,
    nombre_local character varying(100) NOT NULL,
    direccion character varying(255),
    telefono character varying(20),
    responsable character varying(100)
);
    DROP TABLE public.locales;
       public         heap r       postgres    false            �            1259    41704    movimientos_inventario    TABLE     %  CREATE TABLE public.movimientos_inventario (
    id_movimiento integer NOT NULL,
    id_producto integer NOT NULL,
    id_local integer NOT NULL,
    tipo_movimiento character varying(20),
    cantidad integer,
    fecha date,
    id_usuario integer,
    comentarios character varying(255)
);
 *   DROP TABLE public.movimientos_inventario;
       public         heap r       postgres    false            �            1259    41692    permisos_rol    TABLE     �   CREATE TABLE public.permisos_rol (
    id_rol integer NOT NULL,
    id_controlador integer NOT NULL,
    permiso character varying(50)
);
     DROP TABLE public.permisos_rol;
       public         heap r       postgres    false            �            1259    41667    producto_categoria    TABLE     p   CREATE TABLE public.producto_categoria (
    id_producto integer NOT NULL,
    id_categoria integer NOT NULL
);
 &   DROP TABLE public.producto_categoria;
       public         heap r       postgres    false            �            1259    41660 	   productos    TABLE     �  CREATE TABLE public.productos (
    id_producto integer NOT NULL,
    nombre character varying(100) NOT NULL,
    descripcion character varying(255),
    cantidad_total integer,
    precio_costo numeric(10,2),
    id_proveedor integer,
    fecha_registro date,
    foto bytea,
    peso numeric(10,2),
    ancho numeric(10,2),
    alto numeric(10,2),
    grosor numeric(10,2),
    id_clasificacion integer
);
    DROP TABLE public.productos;
       public         heap r       postgres    false            �            1259    41653    proveedores    TABLE     4  CREATE TABLE public.proveedores (
    id_proveedor integer NOT NULL,
    nombre character varying(100) NOT NULL,
    contacto character varying(100),
    telefono character varying(20),
    email character varying(100),
    direccion character varying(255),
    condiciones_entrega character varying(255)
);
    DROP TABLE public.proveedores;
       public         heap r       postgres    false            �            1259    41682    roles    TABLE     �   CREATE TABLE public.roles (
    id_rol integer NOT NULL,
    nombre_rol character varying(100) NOT NULL,
    descripcion character varying(255)
);
    DROP TABLE public.roles;
       public         heap r       postgres    false            �            1259    41697    usuarios    TABLE     �   CREATE TABLE public.usuarios (
    id_usuario integer NOT NULL,
    nombre_usuario character varying(100) NOT NULL,
    contrasena character varying(255),
    correo character varying(100),
    id_rol integer,
    fecha_creacion date,
    foto bytea
);
    DROP TABLE public.usuarios;
       public         heap r       postgres    false            8          0    41648 
   categorias 
   TABLE DATA           Q   COPY public.categorias (id_categoria, nombre_categoria, descripcion) FROM stdin;
    public               postgres    false    218   !H       7          0    41643    clasificacion 
   TABLE DATA           O   COPY public.clasificacion (id_clasificacion, nombre_clasificacion) FROM stdin;
    public               postgres    false    217   >H       ?          0    41687    controladores 
   TABLE DATA           X   COPY public.controladores (id_controlador, nombre_controlador, descripcion) FROM stdin;
    public               postgres    false    225   �H       =          0    41677    inventario_local 
   TABLE DATA           v   COPY public.inventario_local (id_inventario, id_producto, id_local, cantidad, fecha_ultima_actualizacion) FROM stdin;
    public               postgres    false    223   eI       <          0    41672    locales 
   TABLE DATA           [   COPY public.locales (id_local, nombre_local, direccion, telefono, responsable) FROM stdin;
    public               postgres    false    222   �I       B          0    41704    movimientos_inventario 
   TABLE DATA           �   COPY public.movimientos_inventario (id_movimiento, id_producto, id_local, tipo_movimiento, cantidad, fecha, id_usuario, comentarios) FROM stdin;
    public               postgres    false    228   �J       @          0    41692    permisos_rol 
   TABLE DATA           G   COPY public.permisos_rol (id_rol, id_controlador, permiso) FROM stdin;
    public               postgres    false    226   �J       ;          0    41667    producto_categoria 
   TABLE DATA           G   COPY public.producto_categoria (id_producto, id_categoria) FROM stdin;
    public               postgres    false    221   �J       :          0    41660 	   productos 
   TABLE DATA           �   COPY public.productos (id_producto, nombre, descripcion, cantidad_total, precio_costo, id_proveedor, fecha_registro, foto, peso, ancho, alto, grosor, id_clasificacion) FROM stdin;
    public               postgres    false    220   �J       9          0    41653    proveedores 
   TABLE DATA           v   COPY public.proveedores (id_proveedor, nombre, contacto, telefono, email, direccion, condiciones_entrega) FROM stdin;
    public               postgres    false    219   L       >          0    41682    roles 
   TABLE DATA           @   COPY public.roles (id_rol, nombre_rol, descripcion) FROM stdin;
    public               postgres    false    224   5M       A          0    41697    usuarios 
   TABLE DATA           p   COPY public.usuarios (id_usuario, nombre_usuario, contrasena, correo, id_rol, fecha_creacion, foto) FROM stdin;
    public               postgres    false    227   N       �           2606    41652    categorias categorias_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.categorias
    ADD CONSTRAINT categorias_pkey PRIMARY KEY (id_categoria);
 D   ALTER TABLE ONLY public.categorias DROP CONSTRAINT categorias_pkey;
       public                 postgres    false    218            �           2606    41647     clasificacion clasificacion_pkey 
   CONSTRAINT     l   ALTER TABLE ONLY public.clasificacion
    ADD CONSTRAINT clasificacion_pkey PRIMARY KEY (id_clasificacion);
 J   ALTER TABLE ONLY public.clasificacion DROP CONSTRAINT clasificacion_pkey;
       public                 postgres    false    217            �           2606    41691     controladores controladores_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public.controladores
    ADD CONSTRAINT controladores_pkey PRIMARY KEY (id_controlador);
 J   ALTER TABLE ONLY public.controladores DROP CONSTRAINT controladores_pkey;
       public                 postgres    false    225            �           2606    41681 &   inventario_local inventario_local_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public.inventario_local
    ADD CONSTRAINT inventario_local_pkey PRIMARY KEY (id_inventario);
 P   ALTER TABLE ONLY public.inventario_local DROP CONSTRAINT inventario_local_pkey;
       public                 postgres    false    223            �           2606    41676    locales locales_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.locales
    ADD CONSTRAINT locales_pkey PRIMARY KEY (id_local);
 >   ALTER TABLE ONLY public.locales DROP CONSTRAINT locales_pkey;
       public                 postgres    false    222            �           2606    41708 2   movimientos_inventario movimientos_inventario_pkey 
   CONSTRAINT     {   ALTER TABLE ONLY public.movimientos_inventario
    ADD CONSTRAINT movimientos_inventario_pkey PRIMARY KEY (id_movimiento);
 \   ALTER TABLE ONLY public.movimientos_inventario DROP CONSTRAINT movimientos_inventario_pkey;
       public                 postgres    false    228            �           2606    41696    permisos_rol permisos_rol_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public.permisos_rol
    ADD CONSTRAINT permisos_rol_pkey PRIMARY KEY (id_rol, id_controlador);
 H   ALTER TABLE ONLY public.permisos_rol DROP CONSTRAINT permisos_rol_pkey;
       public                 postgres    false    226    226            �           2606    41671 *   producto_categoria producto_categoria_pkey 
   CONSTRAINT        ALTER TABLE ONLY public.producto_categoria
    ADD CONSTRAINT producto_categoria_pkey PRIMARY KEY (id_producto, id_categoria);
 T   ALTER TABLE ONLY public.producto_categoria DROP CONSTRAINT producto_categoria_pkey;
       public                 postgres    false    221    221            �           2606    41666    productos productos_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (id_producto);
 B   ALTER TABLE ONLY public.productos DROP CONSTRAINT productos_pkey;
       public                 postgres    false    220            �           2606    41659    proveedores proveedores_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public.proveedores
    ADD CONSTRAINT proveedores_pkey PRIMARY KEY (id_proveedor);
 F   ALTER TABLE ONLY public.proveedores DROP CONSTRAINT proveedores_pkey;
       public                 postgres    false    219            �           2606    41686    roles roles_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (id_rol);
 :   ALTER TABLE ONLY public.roles DROP CONSTRAINT roles_pkey;
       public                 postgres    false    224            �           2606    41703    usuarios usuarios_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_pkey PRIMARY KEY (id_usuario);
 @   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_pkey;
       public                 postgres    false    227            �           2606    41734 ,   inventario_local fk_inventario_local_locales    FK CONSTRAINT     �   ALTER TABLE ONLY public.inventario_local
    ADD CONSTRAINT fk_inventario_local_locales FOREIGN KEY (id_local) REFERENCES public.locales(id_local) ON UPDATE CASCADE ON DELETE CASCADE;
 V   ALTER TABLE ONLY public.inventario_local DROP CONSTRAINT fk_inventario_local_locales;
       public               postgres    false    4749    222    223            �           2606    41729 .   inventario_local fk_inventario_local_productos    FK CONSTRAINT     �   ALTER TABLE ONLY public.inventario_local
    ADD CONSTRAINT fk_inventario_local_productos FOREIGN KEY (id_producto) REFERENCES public.productos(id_producto) ON UPDATE CASCADE ON DELETE CASCADE;
 X   ALTER TABLE ONLY public.inventario_local DROP CONSTRAINT fk_inventario_local_productos;
       public               postgres    false    223    4745    220            �           2606    41759 8   movimientos_inventario fk_movimientos_inventario_locales    FK CONSTRAINT     �   ALTER TABLE ONLY public.movimientos_inventario
    ADD CONSTRAINT fk_movimientos_inventario_locales FOREIGN KEY (id_local) REFERENCES public.locales(id_local) ON UPDATE CASCADE ON DELETE CASCADE;
 b   ALTER TABLE ONLY public.movimientos_inventario DROP CONSTRAINT fk_movimientos_inventario_locales;
       public               postgres    false    4749    222    228            �           2606    41754 :   movimientos_inventario fk_movimientos_inventario_productos    FK CONSTRAINT     �   ALTER TABLE ONLY public.movimientos_inventario
    ADD CONSTRAINT fk_movimientos_inventario_productos FOREIGN KEY (id_producto) REFERENCES public.productos(id_producto) ON UPDATE CASCADE ON DELETE CASCADE;
 d   ALTER TABLE ONLY public.movimientos_inventario DROP CONSTRAINT fk_movimientos_inventario_productos;
       public               postgres    false    4745    228    220            �           2606    41764 9   movimientos_inventario fk_movimientos_inventario_usuarios    FK CONSTRAINT     �   ALTER TABLE ONLY public.movimientos_inventario
    ADD CONSTRAINT fk_movimientos_inventario_usuarios FOREIGN KEY (id_usuario) REFERENCES public.usuarios(id_usuario) ON UPDATE CASCADE ON DELETE SET NULL;
 c   ALTER TABLE ONLY public.movimientos_inventario DROP CONSTRAINT fk_movimientos_inventario_usuarios;
       public               postgres    false    227    228    4759            �           2606    41744 *   permisos_rol fk_permisos_rol_controladores    FK CONSTRAINT     �   ALTER TABLE ONLY public.permisos_rol
    ADD CONSTRAINT fk_permisos_rol_controladores FOREIGN KEY (id_controlador) REFERENCES public.controladores(id_controlador) ON UPDATE CASCADE ON DELETE CASCADE;
 T   ALTER TABLE ONLY public.permisos_rol DROP CONSTRAINT fk_permisos_rol_controladores;
       public               postgres    false    226    225    4755            �           2606    41739 "   permisos_rol fk_permisos_rol_roles    FK CONSTRAINT     �   ALTER TABLE ONLY public.permisos_rol
    ADD CONSTRAINT fk_permisos_rol_roles FOREIGN KEY (id_rol) REFERENCES public.roles(id_rol) ON UPDATE CASCADE ON DELETE CASCADE;
 L   ALTER TABLE ONLY public.permisos_rol DROP CONSTRAINT fk_permisos_rol_roles;
       public               postgres    false    4753    226    224            �           2606    41724 3   producto_categoria fk_producto_categoria_categorias    FK CONSTRAINT     �   ALTER TABLE ONLY public.producto_categoria
    ADD CONSTRAINT fk_producto_categoria_categorias FOREIGN KEY (id_categoria) REFERENCES public.categorias(id_categoria) ON UPDATE CASCADE ON DELETE CASCADE;
 ]   ALTER TABLE ONLY public.producto_categoria DROP CONSTRAINT fk_producto_categoria_categorias;
       public               postgres    false    218    221    4741            �           2606    41719 2   producto_categoria fk_producto_categoria_productos    FK CONSTRAINT     �   ALTER TABLE ONLY public.producto_categoria
    ADD CONSTRAINT fk_producto_categoria_productos FOREIGN KEY (id_producto) REFERENCES public.productos(id_producto) ON UPDATE CASCADE ON DELETE CASCADE;
 \   ALTER TABLE ONLY public.producto_categoria DROP CONSTRAINT fk_producto_categoria_productos;
       public               postgres    false    220    4745    221            �           2606    41769 $   productos fk_productos_clasificacion    FK CONSTRAINT     �   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT fk_productos_clasificacion FOREIGN KEY (id_clasificacion) REFERENCES public.clasificacion(id_clasificacion) ON UPDATE CASCADE ON DELETE CASCADE;
 N   ALTER TABLE ONLY public.productos DROP CONSTRAINT fk_productos_clasificacion;
       public               postgres    false    217    220    4739            �           2606    41709 "   productos fk_productos_proveedores    FK CONSTRAINT     �   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT fk_productos_proveedores FOREIGN KEY (id_proveedor) REFERENCES public.proveedores(id_proveedor) ON UPDATE CASCADE ON DELETE SET NULL;
 L   ALTER TABLE ONLY public.productos DROP CONSTRAINT fk_productos_proveedores;
       public               postgres    false    4743    219    220            �           2606    41749    usuarios fk_usuarios_roles    FK CONSTRAINT     �   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT fk_usuarios_roles FOREIGN KEY (id_rol) REFERENCES public.roles(id_rol) ON UPDATE CASCADE ON DELETE SET NULL;
 D   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT fk_usuarios_roles;
       public               postgres    false    224    4753    227            8      x������ � �      7   5   x�3��M,J�/�2�,�L)���2�L-.)M�H�2����-�LL�/����� >Bc      ?   �   x�e�Mn1F��)r�
�����K*~v�XE
���p+V���af@����{�2�a�T�#|SL�z	ڒ�j��0с�z�2T=��3k�'"�B��7j_!	ڑ�zXH5z��)�P�
[�n\�+����6�GwIKڡ�M�z�}7��~�Y����h�;l�fIwk ��!�Q��.1�̽�$/��\��;p�[�Qӱ�ߔ��F)uw��      =      x������ � �      <     x�M��N�0���S�R���mHh@�rB\�&��On;	ކ#��x���$�C���~���u�a��Ȥv轃����G���X��+���J��T�~� ����S�	�H<:�9��[�<��4	��#�2e�g�y>#�!wr�"aډS+�z��Q��u-~�`O柣�P&�~��Ad�俤"@����h�����L"<�X��ɻ�]b0U�,鈑-H+�q�	d�q>�T��zR�e����?H�&�biЯ�Z�_��w,      B      x������ � �      @      x������ � �      ;      x������ � �      :     x�e�;n�0�g�ڋz6�Xt�v隅��m���6=C���Utܸ@B��~�2pHCI�I��e�g�0����(#��I��\��66��Xm��؍6p|�L �UM���#,<�;��rH�L�q�*�;��[]��������5�mM�i`"�b*X���Iy�C��j=^�{���o5�5���߁�w&<��1���6'�"�L%��^���u�d|�����^���ˎǤ�^����~�c� c�wU�����X���U������x�kN��@���      9     x�]�KN�@�יS����clP%`�ؘ�#M<�g��p Nы�5������g�)�&"������O��\��n�)�jsC:���Pt(B��)H"�z��I�!j�ћ*�܇xQ�A�ʟ�~��o'bg��٢8��]/
�Y�	M����/9��vWV�<���L����J<�R�e ��Rf�W�s�����/��=�^twP��>1�`�?�����<ESg���k��*%\���vFO���T�����6�}�+c�/����      >   �   x�u�Aj�0E��)t�@;���~�̪a�E�X��Cs�a.6rZR�� ���n�g�Z0Jq�L� C 2͉� B��
��{ˁ%�B�jI�p����f*�_
"��߾2�Ph�RIrc�0X��{!�A�ܛٿ+(&�A�"��*j{��;��2�'w����P�����ȳ;���-@�!5奫$������0�o����dyf      A   �   x�u��
� E��1Ԓ}���r*#5��e�~�`ه9��\��Ɲ���yh�v]���˚qq,h����O�Ӟ`�_>h��AnD��Xò�؍z�p�U&'�T%�<��訋�lD��@iv���"�
,��@������S����W*�s}u|��>w=���\��B2�H��,��MQh�     