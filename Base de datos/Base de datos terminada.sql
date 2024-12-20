PGDMP      ;    
        
    |            Prueba    17.0    17.0 4    K           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            L           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            M           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            N           1262    16441    Prueba    DATABASE     {   CREATE DATABASE "Prueba" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Spanish_Spain.1252';
    DROP DATABASE "Prueba";
                     postgres    false            �            1259    16757 
   categorias    TABLE     �   CREATE TABLE public.categorias (
    id_categoria character varying(30) NOT NULL,
    nombre_categoria character varying(255) NOT NULL,
    descripcion_categoria text
);
    DROP TABLE public.categorias;
       public         heap r       postgres    false            �            1259    16818    controladores    TABLE     �   CREATE TABLE public.controladores (
    id_controlador character varying(30) NOT NULL,
    nombre_controlador character varying(255) NOT NULL,
    descripcion_controlador text
);
 !   DROP TABLE public.controladores;
       public         heap r       postgres    false            �            1259    16865    inventario_local    TABLE       CREATE TABLE public.inventario_local (
    id_inventario character varying(30) NOT NULL,
    id_producto character varying(30),
    id_local character varying(30),
    cantidad integer NOT NULL,
    fecha_ultima_actualizacion timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
 $   DROP TABLE public.inventario_local;
       public         heap r       postgres    false            �            1259    16766    locales    TABLE       CREATE TABLE public.locales (
    id_local character varying(30) NOT NULL,
    nombre_local character varying(255) NOT NULL,
    direccion_local character varying(255),
    telefono_local character varying(20),
    responsable_local character varying(255)
);
    DROP TABLE public.locales;
       public         heap r       postgres    false            �            1259    16843    movimientos_inventario    TABLE       CREATE TABLE public.movimientos_inventario (
    id_movimiento character varying(30) NOT NULL,
    id_producto character varying(30),
    id_local character varying(30),
    tipo_movimiento character varying(50),
    cantidad integer NOT NULL,
    fecha_movimiento timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    id_usuario character varying(30),
    CONSTRAINT movimientos_inventario_tipo_movimiento_check CHECK (((tipo_movimiento)::text = ANY ((ARRAY['entrada'::character varying, 'salida'::character varying])::text[])))
);
 *   DROP TABLE public.movimientos_inventario;
       public         heap r       postgres    false            �            1259    16827    permisos_rol    TABLE     `  CREATE TABLE public.permisos_rol (
    id_rol character varying(30) NOT NULL,
    id_controlador character varying(30) NOT NULL,
    permiso character varying(50),
    CONSTRAINT permisos_rol_permiso_check CHECK (((permiso)::text = ANY ((ARRAY['Lectura'::character varying, 'Escritura'::character varying, 'Completo'::character varying])::text[])))
);
     DROP TABLE public.permisos_rol;
       public         heap r       postgres    false            �            1259    16881    producto_categoria    TABLE     �   CREATE TABLE public.producto_categoria (
    id_producto character varying(30) NOT NULL,
    id_categoria character varying(30) NOT NULL
);
 &   DROP TABLE public.producto_categoria;
       public         heap r       postgres    false            �            1259    16773 	   productos    TABLE     `  CREATE TABLE public.productos (
    id_producto character varying(30) NOT NULL,
    nombre_producto character varying(100) NOT NULL,
    descripcion_producto text,
    cantidad_total integer NOT NULL,
    precio_costo numeric NOT NULL,
    id_proveedor character varying(30),
    fecha_registro timestamp without time zone DEFAULT CURRENT_TIMESTAMP
);
    DROP TABLE public.productos;
       public         heap r       postgres    false            �            1259    16741    proveedores    TABLE     b  CREATE TABLE public.proveedores (
    id_proveedor character varying(30) NOT NULL,
    nombre_proveedor character varying(255) NOT NULL,
    contacto_proveedor character varying(255),
    telefono_proveedor character varying(20),
    email_proveedor character varying(255),
    direccion_proveedor character varying(255),
    condiciones_entrega text
);
    DROP TABLE public.proveedores;
       public         heap r       postgres    false            �            1259    16748    roles    TABLE     �   CREATE TABLE public.roles (
    id_rol character varying(30) NOT NULL,
    nombre_rol character varying(255) NOT NULL,
    descripcion_rol text
);
    DROP TABLE public.roles;
       public         heap r       postgres    false            �            1259    16803    usuarios    TABLE     �  CREATE TABLE public.usuarios (
    id_usuario character varying(30) NOT NULL,
    nombre_usuario character varying(255) NOT NULL,
    apellido_paterno character varying(255) NOT NULL,
    apellido_materno character varying(255) NOT NULL,
    contrasena character varying(255) NOT NULL,
    correo_usuario character varying(255),
    id_rol character varying(30),
    fecha_creacion timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    foto bytea
);
    DROP TABLE public.usuarios;
       public         heap r       postgres    false            @          0    16757 
   categorias 
   TABLE DATA           [   COPY public.categorias (id_categoria, nombre_categoria, descripcion_categoria) FROM stdin;
    public               postgres    false    219   �J       D          0    16818    controladores 
   TABLE DATA           d   COPY public.controladores (id_controlador, nombre_controlador, descripcion_controlador) FROM stdin;
    public               postgres    false    223   K       G          0    16865    inventario_local 
   TABLE DATA           v   COPY public.inventario_local (id_inventario, id_producto, id_local, cantidad, fecha_ultima_actualizacion) FROM stdin;
    public               postgres    false    226   )K       A          0    16766    locales 
   TABLE DATA           m   COPY public.locales (id_local, nombre_local, direccion_local, telefono_local, responsable_local) FROM stdin;
    public               postgres    false    220   FK       F          0    16843    movimientos_inventario 
   TABLE DATA           �   COPY public.movimientos_inventario (id_movimiento, id_producto, id_local, tipo_movimiento, cantidad, fecha_movimiento, id_usuario) FROM stdin;
    public               postgres    false    225   cK       E          0    16827    permisos_rol 
   TABLE DATA           G   COPY public.permisos_rol (id_rol, id_controlador, permiso) FROM stdin;
    public               postgres    false    224   �K       H          0    16881    producto_categoria 
   TABLE DATA           G   COPY public.producto_categoria (id_producto, id_categoria) FROM stdin;
    public               postgres    false    227   �K       B          0    16773 	   productos 
   TABLE DATA           �   COPY public.productos (id_producto, nombre_producto, descripcion_producto, cantidad_total, precio_costo, id_proveedor, fecha_registro) FROM stdin;
    public               postgres    false    221   �K       >          0    16741    proveedores 
   TABLE DATA           �   COPY public.proveedores (id_proveedor, nombre_proveedor, contacto_proveedor, telefono_proveedor, email_proveedor, direccion_proveedor, condiciones_entrega) FROM stdin;
    public               postgres    false    217   �K       ?          0    16748    roles 
   TABLE DATA           D   COPY public.roles (id_rol, nombre_rol, descripcion_rol) FROM stdin;
    public               postgres    false    218   �K       C          0    16803    usuarios 
   TABLE DATA           �   COPY public.usuarios (id_usuario, nombre_usuario, apellido_paterno, apellido_materno, contrasena, correo_usuario, id_rol, fecha_creacion, foto) FROM stdin;
    public               postgres    false    222   L       �           2606    16765 *   categorias categorias_nombre_categoria_key 
   CONSTRAINT     q   ALTER TABLE ONLY public.categorias
    ADD CONSTRAINT categorias_nombre_categoria_key UNIQUE (nombre_categoria);
 T   ALTER TABLE ONLY public.categorias DROP CONSTRAINT categorias_nombre_categoria_key;
       public                 postgres    false    219            �           2606    16763    categorias categorias_pkey 
   CONSTRAINT     b   ALTER TABLE ONLY public.categorias
    ADD CONSTRAINT categorias_pkey PRIMARY KEY (id_categoria);
 D   ALTER TABLE ONLY public.categorias DROP CONSTRAINT categorias_pkey;
       public                 postgres    false    219            �           2606    16826 2   controladores controladores_nombre_controlador_key 
   CONSTRAINT     {   ALTER TABLE ONLY public.controladores
    ADD CONSTRAINT controladores_nombre_controlador_key UNIQUE (nombre_controlador);
 \   ALTER TABLE ONLY public.controladores DROP CONSTRAINT controladores_nombre_controlador_key;
       public                 postgres    false    223            �           2606    16824     controladores controladores_pkey 
   CONSTRAINT     j   ALTER TABLE ONLY public.controladores
    ADD CONSTRAINT controladores_pkey PRIMARY KEY (id_controlador);
 J   ALTER TABLE ONLY public.controladores DROP CONSTRAINT controladores_pkey;
       public                 postgres    false    223            �           2606    16870 &   inventario_local inventario_local_pkey 
   CONSTRAINT     o   ALTER TABLE ONLY public.inventario_local
    ADD CONSTRAINT inventario_local_pkey PRIMARY KEY (id_inventario);
 P   ALTER TABLE ONLY public.inventario_local DROP CONSTRAINT inventario_local_pkey;
       public                 postgres    false    226            �           2606    16772    locales locales_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.locales
    ADD CONSTRAINT locales_pkey PRIMARY KEY (id_local);
 >   ALTER TABLE ONLY public.locales DROP CONSTRAINT locales_pkey;
       public                 postgres    false    220            �           2606    16849 2   movimientos_inventario movimientos_inventario_pkey 
   CONSTRAINT     {   ALTER TABLE ONLY public.movimientos_inventario
    ADD CONSTRAINT movimientos_inventario_pkey PRIMARY KEY (id_movimiento);
 \   ALTER TABLE ONLY public.movimientos_inventario DROP CONSTRAINT movimientos_inventario_pkey;
       public                 postgres    false    225            �           2606    16832    permisos_rol permisos_rol_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public.permisos_rol
    ADD CONSTRAINT permisos_rol_pkey PRIMARY KEY (id_rol, id_controlador);
 H   ALTER TABLE ONLY public.permisos_rol DROP CONSTRAINT permisos_rol_pkey;
       public                 postgres    false    224    224            �           2606    16885 *   producto_categoria producto_categoria_pkey 
   CONSTRAINT        ALTER TABLE ONLY public.producto_categoria
    ADD CONSTRAINT producto_categoria_pkey PRIMARY KEY (id_categoria, id_producto);
 T   ALTER TABLE ONLY public.producto_categoria DROP CONSTRAINT producto_categoria_pkey;
       public                 postgres    false    227    227            �           2606    16780    productos productos_pkey 
   CONSTRAINT     _   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_pkey PRIMARY KEY (id_producto);
 B   ALTER TABLE ONLY public.productos DROP CONSTRAINT productos_pkey;
       public                 postgres    false    221            �           2606    16747    proveedores proveedores_pkey 
   CONSTRAINT     d   ALTER TABLE ONLY public.proveedores
    ADD CONSTRAINT proveedores_pkey PRIMARY KEY (id_proveedor);
 F   ALTER TABLE ONLY public.proveedores DROP CONSTRAINT proveedores_pkey;
       public                 postgres    false    217            �           2606    16756    roles roles_nombre_rol_key 
   CONSTRAINT     [   ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_nombre_rol_key UNIQUE (nombre_rol);
 D   ALTER TABLE ONLY public.roles DROP CONSTRAINT roles_nombre_rol_key;
       public                 postgres    false    218            �           2606    16754    roles roles_pkey 
   CONSTRAINT     R   ALTER TABLE ONLY public.roles
    ADD CONSTRAINT roles_pkey PRIMARY KEY (id_rol);
 :   ALTER TABLE ONLY public.roles DROP CONSTRAINT roles_pkey;
       public                 postgres    false    218            �           2606    16812 $   usuarios usuarios_correo_usuario_key 
   CONSTRAINT     i   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_correo_usuario_key UNIQUE (correo_usuario);
 N   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_correo_usuario_key;
       public                 postgres    false    222            �           2606    16810    usuarios usuarios_pkey 
   CONSTRAINT     \   ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_pkey PRIMARY KEY (id_usuario);
 @   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_pkey;
       public                 postgres    false    222            �           2606    16876 /   inventario_local inventario_local_id_local_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.inventario_local
    ADD CONSTRAINT inventario_local_id_local_fkey FOREIGN KEY (id_local) REFERENCES public.locales(id_local);
 Y   ALTER TABLE ONLY public.inventario_local DROP CONSTRAINT inventario_local_id_local_fkey;
       public               postgres    false    4751    226    220            �           2606    16871 2   inventario_local inventario_local_id_producto_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.inventario_local
    ADD CONSTRAINT inventario_local_id_producto_fkey FOREIGN KEY (id_producto) REFERENCES public.productos(id_producto);
 \   ALTER TABLE ONLY public.inventario_local DROP CONSTRAINT inventario_local_id_producto_fkey;
       public               postgres    false    226    221    4753            �           2606    16855 ;   movimientos_inventario movimientos_inventario_id_local_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.movimientos_inventario
    ADD CONSTRAINT movimientos_inventario_id_local_fkey FOREIGN KEY (id_local) REFERENCES public.locales(id_local);
 e   ALTER TABLE ONLY public.movimientos_inventario DROP CONSTRAINT movimientos_inventario_id_local_fkey;
       public               postgres    false    220    225    4751            �           2606    16850 >   movimientos_inventario movimientos_inventario_id_producto_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.movimientos_inventario
    ADD CONSTRAINT movimientos_inventario_id_producto_fkey FOREIGN KEY (id_producto) REFERENCES public.productos(id_producto);
 h   ALTER TABLE ONLY public.movimientos_inventario DROP CONSTRAINT movimientos_inventario_id_producto_fkey;
       public               postgres    false    225    221    4753            �           2606    16860 =   movimientos_inventario movimientos_inventario_id_usuario_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.movimientos_inventario
    ADD CONSTRAINT movimientos_inventario_id_usuario_fkey FOREIGN KEY (id_usuario) REFERENCES public.usuarios(id_usuario);
 g   ALTER TABLE ONLY public.movimientos_inventario DROP CONSTRAINT movimientos_inventario_id_usuario_fkey;
       public               postgres    false    222    225    4757            �           2606    16838 -   permisos_rol permisos_rol_id_controlador_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.permisos_rol
    ADD CONSTRAINT permisos_rol_id_controlador_fkey FOREIGN KEY (id_controlador) REFERENCES public.controladores(id_controlador);
 W   ALTER TABLE ONLY public.permisos_rol DROP CONSTRAINT permisos_rol_id_controlador_fkey;
       public               postgres    false    224    4761    223            �           2606    16833 %   permisos_rol permisos_rol_id_rol_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.permisos_rol
    ADD CONSTRAINT permisos_rol_id_rol_fkey FOREIGN KEY (id_rol) REFERENCES public.roles(id_rol);
 O   ALTER TABLE ONLY public.permisos_rol DROP CONSTRAINT permisos_rol_id_rol_fkey;
       public               postgres    false    4745    218    224            �           2606    16891 7   producto_categoria producto_categoria_id_categoria_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.producto_categoria
    ADD CONSTRAINT producto_categoria_id_categoria_fkey FOREIGN KEY (id_categoria) REFERENCES public.categorias(id_categoria);
 a   ALTER TABLE ONLY public.producto_categoria DROP CONSTRAINT producto_categoria_id_categoria_fkey;
       public               postgres    false    4749    227    219            �           2606    16886 6   producto_categoria producto_categoria_id_producto_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.producto_categoria
    ADD CONSTRAINT producto_categoria_id_producto_fkey FOREIGN KEY (id_producto) REFERENCES public.productos(id_producto);
 `   ALTER TABLE ONLY public.producto_categoria DROP CONSTRAINT producto_categoria_id_producto_fkey;
       public               postgres    false    221    227    4753            �           2606    16781 %   productos productos_id_proveedor_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.productos
    ADD CONSTRAINT productos_id_proveedor_fkey FOREIGN KEY (id_proveedor) REFERENCES public.proveedores(id_proveedor);
 O   ALTER TABLE ONLY public.productos DROP CONSTRAINT productos_id_proveedor_fkey;
       public               postgres    false    221    4741    217            �           2606    16813    usuarios usuarios_id_rol_fkey    FK CONSTRAINT        ALTER TABLE ONLY public.usuarios
    ADD CONSTRAINT usuarios_id_rol_fkey FOREIGN KEY (id_rol) REFERENCES public.roles(id_rol);
 G   ALTER TABLE ONLY public.usuarios DROP CONSTRAINT usuarios_id_rol_fkey;
       public               postgres    false    222    218    4745            @      x������ � �      D      x������ � �      G      x������ � �      A      x������ � �      F      x������ � �      E      x������ � �      H      x������ � �      B      x������ � �      >      x������ � �      ?      x������ � �      C      x������ � �     